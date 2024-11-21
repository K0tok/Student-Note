using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Note
{
    public partial class MainForm : Form
    {
        private ScheduleLoader _scheduleLoader;
        public MainForm()
        {
            InitializeComponent();
            _scheduleLoader = new ScheduleLoader();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Вызов функции, которая загрузит и выведет данные
            //await new Server().GetScheduleAsync();
            // Data_Base.DBConnection();

            // Загружаем расписание
            await _scheduleLoader.GetScheduleAsync();

            // Проверяем, загружено ли расписание
            if (_scheduleLoader.CurrentSchedule != null &&
                _scheduleLoader.CurrentSchedule.Groups.TryGetValue("Т-233901-ИСТ", out var groupSchedule))
            {
                // Заполняем таблицы
                FillSchedule(
                    MondayTLP, TuesdayTLP, WednesdayTLP,
                    ThursdayTLP, FridayTLP, SaturdayTLP,
                    groupSchedule);
            }
            else
            {
                MessageBox.Show("Расписание не найдено.");
            }
            
            // Получение списка недель 
            DateTime startDate = new DateTime(DateTime.Now.Year, 9, 2);
            DateTime endDate = new DateTime(DateTime.Now.Year + 1, 5, 31);
            List<Week> weeks = new List<Week>();
            int id = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(7))
            {
                Week week = new Week
                {
                    Id = id,
                    WeekNumber = id+1,
                    StartDate = date,
                    EndDate = date.AddDays(6)
                };
                weeks.Add(week);
                id++;
            }

            foreach (var week in weeks)
            {
                string weekString = $"{week.WeekNumber} неделя ({week.StartDate.ToShortDateString()} - {week.EndDate.ToShortDateString()})";
                WeekComboBox.Items.Add(weekString);
            }

            DateTime currentDate = DateTime.Now;
            int currentWeekId = 0;
            foreach (var week in weeks)
            {
                if (currentDate >= week.StartDate && currentDate <= week.EndDate)
                {
                    currentWeekId = week.Id;
                    break;
                }
            }
            WeekComboBox.SelectedIndex = currentWeekId;
        }

        public void FillSchedule(TableLayoutPanel mondayTLP, TableLayoutPanel tuesdayTLP,
                         TableLayoutPanel wednesdayTLP, TableLayoutPanel thursdayTLP,
                         TableLayoutPanel fridayTLP, TableLayoutPanel saturdayTLP,
                         GroupSchedule groupSchedule)
        {
            // Заполняем данные для каждого дня недели
            FillDaySchedule(mondayTLP, groupSchedule.Monday);
            FillDaySchedule(tuesdayTLP, groupSchedule.Tuesday);
            FillDaySchedule(wednesdayTLP, groupSchedule.Wednesday);
            FillDaySchedule(thursdayTLP, groupSchedule.Thursday);
            FillDaySchedule(fridayTLP, groupSchedule.Friday);
            FillDaySchedule(saturdayTLP, groupSchedule.Saturday);
        }

        private void FillDaySchedule(TableLayoutPanel tableLayoutPanel, DaySchedule daySchedule)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 0;
            tableLayoutPanel.RowStyles.Clear();

            // Добавляем заголовки, если нужно (опционально)
            AddRowToTable(tableLayoutPanel, "№", "Предмет", "Домашнее задание", true);

            // Получаем данные для каждого номера пары
            var lessons = new Dictionary<string, List<Lesson>>
                {
                    { "I", daySchedule.I },
                    { "II", daySchedule.II },
                    { "III", daySchedule.III },
                    { "IV", daySchedule.IV },
                    { "V", daySchedule.V },
                    { "I - В", daySchedule.I_V },
                    { "II - В", daySchedule.II_V }
                };

            foreach (var (lessonNumber, lessonList) in lessons)
            {
                if (lessonList != null)
                {
                    foreach (var lesson in lessonList)
                    {
                        var task = !string.IsNullOrEmpty(lesson.Auditorium)
                                    ? $"Аудитория: {lesson.Auditorium}"
                                    : string.Empty;

                        AddRowToTable(tableLayoutPanel, lessonNumber, lesson.Name, task);
                    }
                }
            }
        }

        private void AddRowToTable(TableLayoutPanel tableLayoutPanel, string lessonNumber, string subject, string homework, bool isHeader = false)
        {
            // Создаем текстовые метки для строки
            var lblNumber = new Label { Text = lessonNumber, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
            var lblSubject = new Label { Text = subject, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var lblHomework = new Label { Text = homework, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };

            
            // Добавляем метки в таблицу
            tableLayoutPanel.Controls.Add(lblNumber);
            tableLayoutPanel.Controls.Add(lblSubject);
            tableLayoutPanel.Controls.Add(lblHomework);

            // Увеличиваем количество строк
            tableLayoutPanel.RowCount++;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

    }
}
