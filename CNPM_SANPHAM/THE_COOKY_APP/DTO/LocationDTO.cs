using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_COOKY_APP.DTO
{
    internal class LocationDTO
    {
        public string IdLocation { get; set; }
        public string NameLocation { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int MaxLocationQuantity { get; set; }
        public bool IsActive { get; set; } // Changed from bool to int
    }
}
