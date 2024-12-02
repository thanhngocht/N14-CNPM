using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_COOKY_APP.DTO
{
    internal class TopicDTO
    {
        public string IdTopic { get; set; }
        public string NameTopic { get; set; }
        public  bool IsActive { get; set; } // Changed from bool to int
    }
}
