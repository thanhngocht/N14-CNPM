using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace THE_COOKY_APP.DTO
{
    internal class DataValidator
    {
        // Kiểm tra định dạng ngày tháng
        public bool IsValidDate(string date)
        {
            return DateTime.TryParseExact(date, new[] { "dd/MM/yyyy", "dd-MM-yyyy" },
                CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        // Tính tuổi từ DateTime
        public int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.UtcNow;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }

        // Kiểm tra chuỗi có phải toàn số không
        public bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        // Kiểm tra số điện thoại
        public bool IsPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && Regex.IsMatch(phoneNumber, @"^0[0-9]{9}$"); // Ví dụ cho số điện thoại Việt Nam
        }

        // Kiểm tra địa chỉ email
        public bool IsValidEmail(string email)
        {
            // Kiểm tra định dạng email
            var regex = new Regex(@"^(?!.*\.\.)(?!.*[&=\'-+,<>])([a-zA-Z0-9_]+(\.[a-zA-Z0-9_]+)*)@(gmail\.com|[a-zA-Z0-9.-]+\.edu\.vn)$");
            return regex.IsMatch(email);
        }

        // Kiểm tra chuỗi có không dấu
        public bool HasNoDiacritics(string input)
        {
            // Kiểm tra xem chuỗi có null hoặc rỗng không
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            // Chuẩn hóa chuỗi để tách các ký tự có dấu
            var normalizedString = input.Normalize(NormalizationForm.FormD);
            var stringBuilder = new System.Text.StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                // Chỉ thêm ký tự không phải là dấu và là chữ cái hoặc số
                if (unicodeCategory != UnicodeCategory.NonSpacingMark &&
                    (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    stringBuilder.Append(c);
                }
            }

            // Kiểm tra xem chuỗi đã xây dựng có giống với chuỗi đầu vào không
            return stringBuilder.ToString() == input;
        }

        public bool IsValidName(string name)
        {
            // Biểu thức chính quy để kiểm tra họ và tên
            // Cho phép các ký tự chữ, dấu cách và dấu '
            string namePattern = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềếềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s']+$";
            return Regex.IsMatch(name, namePattern);
        }

        public bool IsValidAddressOrNativePlace(string input)
        {
            // Kiểm tra xem chuỗi có null hoặc rỗng không
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            // Kiểm tra xem chuỗi có bắt đầu hoặc kết thúc bằng dấu phẩy
            if (input.StartsWith(",") || input.EndsWith(","))
            {
                return false;
            }

            // Kiểm tra xem có quá 2 dấu phẩy liên tiếp không
            if (Regex.IsMatch(input, ",{3,}"))
            {
                return false;
            }

            // Kiểm tra xem có quá 2 dấu phẩy liên tiếp không
            if (Regex.IsMatch(input, ",{2}"))
            {
                // Nếu có 2 dấu phẩy liên tiếp, kiểm tra xem có dấu phẩy nào khác không
                return !Regex.IsMatch(input, ",{3,}");
            }

            // Biểu thức chính quy để kiểm tra địa chỉ và nguyên quán
            // Cho phép các ký tự chữ, chữ số, dấu cách và dấu ','
            string pattern = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằ̉ẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ0-9\s,]+$";

            // Kiểm tra xem chuỗi có khớp với biểu thức chính quy không
            if (!Regex.IsMatch(input, pattern))
            {
                return false; // Không hợp lệ nếu không khớp với biểu thức chính quy
            }

            // Kiểm tra xem chuỗi có phải là toàn số không
            if (IsNumeric(input))
            {
                return false; // Không hợp lệ nếu là toàn số
            }

            // Kiểm tra xem chuỗi có phải là toàn dấu phẩy không
            if (Regex.IsMatch(input, @"^,+$"))
            {
                return false; // Không hợp lệ nếu là toàn dấu phẩy
            }

            return true; // Nếu không có vấn đề gì, trả về true
        }
    }
}
