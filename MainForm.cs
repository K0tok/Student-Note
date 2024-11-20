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
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Вызов функции, которая загрузит и выведет данные
            await new Server().GetScheduleAsync();
            //Data_Base.DBConnectionOpen();

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
    }
}
