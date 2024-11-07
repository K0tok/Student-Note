using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Student_Note
{
    public class ScheduleData
    {
        public List<Group> Groups { get; set; }
    }

    public class Group
    {
        public List<Day> Days { get; set; }
    }

    public class Day
    {
        public List<Lesson> Lessons { get; set; }
    }

    public class Lesson
    {
        public List<Couple> Couples { get; set; }
    }

    public class Couple
    {
        public string n { get; set; }
        public string a { get; set; }
        public string p { get; set; }
    }
}
