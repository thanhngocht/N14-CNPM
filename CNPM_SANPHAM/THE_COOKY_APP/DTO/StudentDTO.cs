using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_COOKY_APP.DTO
{
    internal class StudentDTO
    {
        public string IdStudent { get; set; }
        public string NameStudent { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool IsMember { get; set; } // Changed from bool to int
        public int TotalPayment { get; set; }
        public bool IsActive { get; set; } // Changed from bool to int
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
