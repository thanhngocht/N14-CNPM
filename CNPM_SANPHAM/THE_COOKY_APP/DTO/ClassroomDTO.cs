using System;

namespace THE_COOKY_APP.DTO
{
    internal class ClassroomDTO
    {
        public string IdClass { get; set; }
        public string NameClass { get; set; }
        public int DurationHour { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan EndHour { get; set; }
        public string StatusClass { get; set; }
        public int MaxQuantity { get; set; }
        public string Description { get; set; }
        public int QuantityArise { get; set; }
        public decimal ProvisionalRevenue { get; set; }
        public decimal RealRevenue { get; set; }
        public decimal Commission { get; set; }
        public TimeSpan StartHour { get; set; }
        public string Picture { get; set; }
        public string NameTopic { get; set; }
        public string NameChef { get; set; }
        public string NameLocation { get; set; }
        public int MaterialCost { get; set; }
        public int FreelancerCost { get; set; }
        public int AnotherCost { get; set; }
        public string Note { get; set; }
    }
}