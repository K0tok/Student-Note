using System;
using System.Collections.Generic;

namespace Student_Note
{
    public class ScheduleItem
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Subject { get; set; }
        public string Room { get; set; }
    }

    public class ScheduleData
    {
        public List<ScheduleItem> Schedule { get; set; }
    }
}
