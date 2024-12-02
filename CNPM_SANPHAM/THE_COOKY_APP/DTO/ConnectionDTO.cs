using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_COOKY_APP.DTO
{
    public class ConnectionDTO
    {
        private static string connection = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        public static string ConnectionString
        {
            get { return connection; }
            set { connection = value; }
        }
    }
}
