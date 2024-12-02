using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public partial class DetailDescription : Form
    {
        private string name;
        public string descrip { get; private set; }
        public DetailDescription(string nameClass)
        {
            InitializeComponent();
            name = nameClass;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            string key = txtKeyWord.Text;
            if (string.IsNullOrEmpty(key) )
            {
                MessageBox.Show("Bạn vui nhập từ khóa");
                return;
            }
            using (AIDescription aIDescription = new AIDescription(name, key))
            {
                // Hiển thị Form PickTime và kiểm tra kết quả
                if (aIDescription.ShowDialog() == DialogResult.OK)
                {
                    descrip = aIDescription.descrip;
                    this.DialogResult = DialogResult.OK; // Đặt kết quả của Form là OK
                    this.Close(); // Đóng Form
                }
            }
        }
    }
}
