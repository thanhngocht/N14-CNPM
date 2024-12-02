using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_COOKY_APP.DTO
{
    internal class UserFunctionDTO
    {
        public bool InsertStudent { get; set; }
        public bool UpdateStudent { get; set; }
        public bool DeleteStudent { get; set; }
        public bool InsertClass { get; set; }
        public bool UpdateClass { get; set; }
        public bool DeleteClass { get; set; }
        public bool InsertChef { get; set; }
        public bool UpdateChef { get; set; }
        public bool DeleteChef { get; set; }
        public bool ReportClass { get; set; }
        public bool DataReality { get; set; }
        public bool Summary { get; set; }
        public bool ReportLocation { get; set; }
        public bool ReportMonth { get; set; }
        public bool TimeTableOverall { get; set; }
        public bool DataPlan { get; set; }
        public bool GeneralKpi { get; set; }
        public bool TimeTablePlan { get; set; }
        public bool InsertTopic { get; set; }
        public bool UpdateTopic { get; set; }
        public bool DeleteTopic { get; set; }
        public bool InsertLocation { get; set; }
        public bool UpdateLocation { get; set; }
        public bool DeleteLocation { get; set; }
        public bool ListClass { get; set; }
        public bool ListChef { get; set; }
        public bool ListLocation { get; set; }
        public bool ListTopic { get; set; }
        public bool ListStudent { get; set; }
        public string IdRole { get; set; }
        public string IdAccount { get; set; }
    }
}
