using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_COOKY_APP.DTO
{
    internal class ChefDTO
    {
        public string IdChef { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public DateTime StartDate { get; set; }
        public string Gmail { get; set; }
        public bool IsActive { get; set; } // Changed from bool to int
    }
}
