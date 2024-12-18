using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

public class Lesson
{
    [JsonProperty("n")]
    public string Name { get; set; }

    [JsonProperty("a")]
    [JsonConverter(typeof(AuditoriumConverter))] // Используем кастомный конвертер
    public string Auditorium { get; set; }

    [JsonProperty("p")]
    public string Professor { get; set; }

    //[JsonProperty("HomeWork")]
    //public string? HomeWork { get; set; }
}

public class Homework
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("lesson")]
    public string Lesson { get; set; }

    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("lessonNumber")]
    public int LessonNumber { get; set; }

    [JsonProperty("homeworkText")]
    public string HomeworkText { get; set; }

    [JsonProperty("file")]
    public string? File { get; set; }

    [JsonProperty("groupId")]
    public int GroupId { get; set; }

    public Homework(int Id, string Lesson, string Date, int LessonNumber, string HomeworkText, string? File, int GroupId) 
    {
        this.Id = Id;
        this.Lesson = Lesson;
        this.Date = Date;
        this.LessonNumber = LessonNumber;
        this.HomeworkText = HomeworkText;
        this.File = File;
        this.GroupId = GroupId;
    }
}

public class AddSheduleRequest
{
    public string Lesson { get; set; }
    public string Date { get; set; }
    public int LessonNumber { get; set; }
    public string HomeworkText { get; set; }
    public string? File { get; set; }
    public int GroupId { get; set; }
}

public class DaySchedule 
{
    public List<Lesson> I { get; set; }
    public List<Lesson> II { get; set; }
    public List<Lesson> III { get; set; }
    public List<Lesson> IV { get; set; }
    public List<Lesson> V { get; set; }
    [JsonProperty("I - В")]
    public List<Lesson> I_V { get; set; }
    [JsonProperty("II - В")]
    public List<Lesson> II_V { get; set; }
}

public class GroupSchedule
{
    [JsonProperty("ПОНЕДЕЛЬНИК")]
    public DaySchedule Monday { get; set; }

    [JsonProperty("ВТОРНИК")]
    public DaySchedule Tuesday { get; set; }

    [JsonProperty("СРЕДА")]
    public DaySchedule Wednesday { get; set; }

    [JsonProperty("ЧЕТВЕРГ")]
    public DaySchedule Thursday { get; set; }

    [JsonProperty("ПЯТНИЦА")]
    public DaySchedule Friday { get; set; }

    [JsonProperty("СУББОТА")]
    public DaySchedule Saturday { get; set; }
}

public class Schedule
{
    public Dictionary<string, GroupSchedule> Groups { get; set; }

    public static Schedule Deserialize(string json)
    {
        var schedule = new Schedule { Groups = new Dictionary<string, GroupSchedule>() };

        var jsonObject = JsonConvert.DeserializeObject<JObject>(json);
        foreach (var property in jsonObject.Properties())
        {
            // Предполагается, что каждая группа соответствует структуре GroupSchedule
            var groupSchedule = property.Value.ToObject<GroupSchedule>();
            schedule.Groups[property.Name] = groupSchedule;
        }

        return schedule;
    }
}

public class Week
{
    public int Id { get; set; }
    public int WeekNumber { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsNumerator { get; set; }
}

