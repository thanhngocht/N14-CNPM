using OfficeOpenXml;
using OfficeOpenXml.Table.PivotTable;
using OfficeOpenXml.Table;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.DTO;

namespace THE_COOKY_APP.GUI.REPORT
{
    public partial class ReportMonth : Form
    {
        private readonly List<int> months = new List<int>();
        private CheckBox[] monthCheckBoxes;
        private readonly LocationBLL locationBLL = new LocationBLL();
        private readonly ClassroomBLL classroomBLL = new ClassroomBLL();
        private NormalClassBLL normalClassBLL = new NormalClassBLL();
        private FreeClassBLL freeClassBLL = new FreeClassBLL();
        private readonly StudentClassBLL studentClassBLL = new StudentClassBLL();
        public ReportMonth()
        {
            InitializeComponent();
            monthCheckBoxes = new CheckBox[]
            {
                cbMonth1, cbMonth2, cbMonth3, cbMonth4, cbMonth5, cbMonth6,
                cbMonth7, cbMonth8, cbMonth9, cbMonth10, cbMonth11, cbMonth12
            };
        }

        private void UpdateAllMonthCheckBox()
        {
            bool allChecked = months.Count == 12;
            cbAllMonth.Checked = allChecked;
            if (allChecked )
            {
                foreach (var checkBox in monthCheckBoxes)
                {
                    checkBox.Checked = allChecked;
                }
            }
            
        }

        private void MonthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            int month = int.Parse(checkBox.Name.Substring(7));
            if (checkBox.Checked)
            {
                months.Add(month);
            }
            else
            {
                months.Remove(month);
            }

            UpdateAllMonthCheckBox();
        }

        private void cbAllMonth_CheckedChanged(object sender, EventArgs e)
        {
            bool allChecked = cbAllMonth.Checked;
            months.Clear();
            if (allChecked)
            {
                for (int i = 1; i <= 12; i++)
                {
                    months.Add(i);
                }
            }
            UpdateAllMonthCheckBox();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel |.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportFile(dialog.FileName, months);
                    MessageBox.Show("Lưu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi lưu file!" + ex.Message);
                }

            }
        }

        private void ExportFile(string path, List<int> months)
        {
            //Đảm bảo rằng EPPlus có thể sử dụng
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            //Tạo một package Excel mới
            using (var package = new ExcelPackage())
            {
                //Thêm worksheet mới để chứa dữ liệu
                var dataWorksheet = package.Workbook.Worksheets.Add("Dữ liệu");
                string[] headers = {
            "Class",
            "Chef",
            "Location",
            "StartDate",
            "Month",
            "Quantity",
            "Unit Price",
            "GMV",
            "Last Total",
            "Discount",
            "Commission",
            "Ingredient",
            "OtherCost",
            "Completed",
            "Canceled",
        };
                List<LocationDTO> locations = locationBLL.GetAllNameLocations();

                //Thêm header vào dataWorksheet
                for (int i = 0; i < headers.Length; i++)
                {
                    dataWorksheet.Cells[1, i + 1].Value = headers[i];
                }
                #region data
                int row = 2;
                foreach (var location in locations)
                {
                    foreach (var month in months)
                    {
                        List<ClassroomDTO> classes = classroomBLL.GetAllClassroomsByMonth(month, location.IdLocation);
                        foreach (var classroom in classes)
                        {
                            NormalClassDTO normalClassDTO = normalClassBLL.GetNormalClassById(classroom.IdClass);
                            FreeClassDTO freeClassDTO = freeClassBLL.GetFreeClassById(classroom.IdClass);
                            dataWorksheet.Cells[row, 1].Value = classroom.NameClass;
                            dataWorksheet.Cells[row, 2].Value = classroom.NameChef;
                            dataWorksheet.Cells[row, 3].Value = location.NameLocation;
                            dataWorksheet.Cells[row, 4].Value = classroom.StartDate.ToString("dd/MM/yyyy");
                            dataWorksheet.Cells[row, 5].Value = month;
                            int quantity = studentClassBLL.CountStudents(classroom.IdClass);
                            dataWorksheet.Cells[row, 6].Value = quantity;
                            int fee = 0;
                            if (normalClassDTO != null)
                            {
                                fee = Convert.ToInt32(normalClassDTO.Fee);
                            }
                            dataWorksheet.Cells[row, 7].Value = fee;
                            int gmv = fee * quantity;
                            if (freeClassBLL == null)
                            {
                                gmv = fee;
                            }
                            dataWorksheet.Cells[row, 8].Value = gmv;
                            int cashBack = 0;
                            List<StudentClassDTO> students = studentClassBLL.GetAllStudents(classroom.IdClass);
                            foreach (var student in students)
                            {
                                cashBack += student.TotalPayment - CalTotalPaymentNeed(student, normalClassDTO, freeClassDTO);
                            }
                            dataWorksheet.Cells[row, 9].Value = gmv - cashBack;
                            dataWorksheet.Cells[row, 10].Value = cashBack;
                            dataWorksheet.Cells[row, 11].Formula = $"=0.25*H{row}";
                            dataWorksheet.Cells[row, 12].Value = classroom.MaterialCost;
                            dataWorksheet.Cells[row, 13].Value = classroom.AnotherCost;
                            dataWorksheet.Cells[row, 14].Value = 0;
                            dataWorksheet.Cells[row, 15].Value = 1;
                            if (classroom.StatusClass == "Sắp diễn ra")
                            {
                                dataWorksheet.Cells[row, 14].Value = 1;
                                dataWorksheet.Cells[row, 15].Value = 0;
                            }
                            row++;
                        }

                    }
                }

                if (dataWorksheet.Cells["A2"].Value != null)
                {
                    #region pivot table
                    if (cbMonth.Checked)
                    {
                        var pivotTableWorksheet1 = package.Workbook.Worksheets.Add("Sumary month");
                        var pivotTable1 = pivotTableWorksheet1.PivotTables.Add(
                            pivotTableWorksheet1.Cells["A1"],
                            dataWorksheet.Cells[$"A1:{dataWorksheet.Cells[row - 1, headers.Length].ToString()}"],
                            "Pivot Table");

                        // Configure the pivot table
                        pivotTable1.RowFields.Add(pivotTable1.Fields["Month"]);
                        pivotTable1.RowFields.Add(pivotTable1.Fields["Location"]);
                        pivotTable1.RowFields.Add(pivotTable1.Fields["Class"]);

                        for (int i = 3; i < headers.Length; i++)
                        {
                            var field = pivotTable1.Fields[headers[i]];
                            var dataField = pivotTable1.DataFields.Add(field);
                            if (headers[i].Equals("Unit Price"))
                            {
                                dataField.Function = DataFieldFunctions.Average;
                            }
                            else
                            {
                                dataField.Function = DataFieldFunctions.Sum;
                            }
                            dataField.Name = $"{headers[i]} ";
                        }
                        pivotTable1.DataOnRows = false;
                        pivotTable1.RowGrandTotals = true;

                        foreach (var field in pivotTable1.Fields)
                        {
                            field.Compact = false;
                            field.Outline = true;
                        }
                        pivotTable1.OutlineData = true;
                        pivotTable1.PivotTableStyle = PivotTableStyles.Light9;
                    }
                    if (cbLocation.Checked)
                    {
                        var pivotTableWorksheet = package.Workbook.Worksheets.Add("Sumary location");
                        var pivotTable = pivotTableWorksheet.PivotTables.Add(
                            pivotTableWorksheet.Cells["A1"],
                            dataWorksheet.Cells[$"A1:{dataWorksheet.Cells[row - 1, headers.Length].ToString()}"],
                            "Pivot Table");

                        // Configure the pivot table
                        pivotTable.RowFields.Add(pivotTable.Fields["Location"]);
                        pivotTable.RowFields.Add(pivotTable.Fields["Month"]);
                        pivotTable.RowFields.Add(pivotTable.Fields["Class"]);

                        for (int i = 3; i < headers.Length; i++)
                        {
                            var field = pivotTable.Fields[headers[i]];
                            var dataField = pivotTable.DataFields.Add(field);
                            if (headers[i].Equals("Unit Price"))
                            {
                                dataField.Function = DataFieldFunctions.Average;
                            }
                            else
                            {
                                dataField.Function = DataFieldFunctions.Sum;
                            }
                            dataField.Name = $"{headers[i]} ";
                        }
                        pivotTable.DataOnRows = false;
                        pivotTable.RowGrandTotals = true;

                        foreach (var field in pivotTable.Fields)
                        {
                            field.Compact = false;
                            field.Outline = true;
                        }
                        pivotTable.OutlineData = true;
                        pivotTable.PivotTableStyle = PivotTableStyles.Light9;
                    }
                    #endregion pivot
                }

                #region color
                using (var headerRange = dataWorksheet.Cells[1, 1, 1, headers.Length])
                {
                    headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                    dataWorksheet.Cells[1, 14].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    dataWorksheet.Cells[1, 14].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Green);

                    dataWorksheet.Cells[1, 15].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    dataWorksheet.Cells[1, 15].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Red);
                }

                #endregion color
                dataWorksheet.Cells.AutoFitColumns();
                dataWorksheet.Cells[1, 1, 1, 2].AutoFilter = true;
                #endregion data
                package.SaveAs(new FileInfo(path));
            }
        }

        private int CalTotalPaymentNeed(StudentClassDTO studentClass, NormalClassDTO? normalClass, FreeClassDTO? freeClass)
        {
            int quantity = studentClass.Quantity;
            int fee = 0;
            if (normalClass != null && freeClass == null)
            {
                fee = Convert.ToInt32(normalClass.Fee);
            }
            else
            {
                return 0;
            }
            int code = studentClass.CodeMemberDiscount;
            int voucher = studentClass.VoucherDiscount;
            int app = studentClass.AppDiscount;
            int cash = studentClass.Cash;
            int deal = studentClass.DealDiscount;

            double discountRate = GetDiscountRate(quantity);
            double totalAmount = quantity * fee;
            double step1 = totalAmount - totalAmount * discountRate;

            if (step1 <= 0)
            {
                return 0;
            }

            double step2 = step1 - ((code + voucher + app) * 1.0 / 100) * step1 - cash;
            if (step2 <= 0)
            {
                return 0;
            }

            double step3 = step2 - step2 * deal;
            return step3 > 0 ? Convert.ToInt32(step3) : 0;
        }

        private double GetDiscountRate(int quantity)
        {
            if (quantity >= 4) return 0.2;
            if (quantity == 3) return 0.15;
            if (quantity == 2) return 0.1;
            return 0;
        }
    }
}
