using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Student_Note
{
    public partial class MainForm : Form
    {
        public static ScheduleLoader _scheduleLoader = new ScheduleLoader();
        private List<Week> _weeks;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Если при загрузки Main Form нет данных пользователя, то мы возращаем в Login Form
            if (Program.userData == null) { Program.ReplaceForm(Program.LogInForm, this); return; }
            else
            {
                // Отрисовка имени пользователя в кнопке
                if (Program.userData.second_name != "" && Program.userData.second_name!=null)
                    buttonUser.Text = Program.userData.last_name + " " + Program.userData.first_name.First() + "." + Program.userData.second_name.First() + ".";
                else
                    buttonUser.Text = Program.userData.last_name + " " + Program.userData.first_name;

                // Инициализация ContextMenuStrip для выпадающего списка для старосты и обычного студента
                contextMenuStrip1 = new ContextMenuStrip();
                contextMenuStrip1.Items.Add("Профиль", null, (s, e) => Program.ReplaceForm(Program.ProfileForm, this));
                contextMenuStrip1.Items.Add("Уведомления", null, (s, e) => MessageBox.Show("Открыты уведомления"));
                if (Program.userData.member_type) // Дополнительные менюшки для старосты
                {
                    contextMenuStrip1.Items.Add("Группа", null, (s, e) => MessageBox.Show("Показаны участники группы"));
                    contextMenuStrip1.Items.Add("Добавить объявление", null, (s, e) => MessageBox.Show("Открыта форма добавления уведомления"));
                }
                contextMenuStrip1.Items.Add("Настройки", null, (s, e) => MessageBox.Show("Открыты настройки"));
                contextMenuStrip1.Items.Add("Выйти", null, (s, e) => Application.Exit());
            }

            // Проверка на наличие групп у пользователя 
            if (Program.userData.selectGroup==null) { MessageBox.Show("У вас нет групп, пожалуйста присоеденитесь"); return; }

            // Загружаем расписание
            await _scheduleLoader.GetScheduleAsync();
            try
            {
                // Проверяем, загружено ли расписание
                if (_scheduleLoader.CurrentSchedule != null &&
                    _scheduleLoader.CurrentSchedule.Groups.TryGetValue(Program.userData.selectGroup, out var groupSchedule))
                {
                    // Заполняем таблицы для текущей недели (по умолчанию)
                    FillSchedule(
                        MondayTLP, TuesdayTLP, WednesdayTLP,
                        ThursdayTLP, FridayTLP, SaturdayTLP,
                        groupSchedule, GetCurrentWeekType());
                }
                else
                {
                    MessageBox.Show("Расписание не найдено.");
                }
            }
            catch 
            {
                Program.ReplaceForm(Program.LogInForm, this);
            }
            

            // Получение списка недель
            DateTime startDate = new DateTime(DateTime.Now.Year, 9, 2);
            DateTime endDate = new DateTime(DateTime.Now.Year + 1, 5, 31);
            _weeks = new List<Week>();
            int id = 0;
            bool isNumerator = true; // Начинаем с числителя

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(7))
            {
                Week week = new Week
                {
                    Id = id,
                    WeekNumber = id + 1,
                    StartDate = date,
                    EndDate = date.AddDays(6),
                    IsNumerator = isNumerator
                };
                _weeks.Add(week);
                id++;
                isNumerator = !isNumerator;
            }

            // Добавляем недели в ComboBox
            foreach (var week in _weeks)
            {
                string weekString = $"{week.WeekNumber} неделя ({week.StartDate.ToShortDateString()} - {week.EndDate.ToShortDateString()})";
                WeekComboBox.Items.Add(weekString);
            }

            // Устанавливаем текущую неделю в ComboBox
            DateTime currentDate = DateTime.Now;
            int currentWeekId = 0;
            foreach (var week in _weeks)
            {
                if (currentDate >= week.StartDate && currentDate <= week.EndDate)
                {
                    currentWeekId = week.Id;
                    WeekComboBox.SelectedIndex = currentWeekId;  // Устанавливаем индекс выбранной недели
                    break;
                }
            }
        }
        /// <summary>
        /// Определяем тип недели (числитель или знаменатель)
        /// </summary>
        /// <returns></returns>
        private bool GetCurrentWeekType()
        {
            var startDate = new DateTime(DateTime.Now.Year, 9, 2);
            var currentDate = DateTime.Now;
            var weekNumber = (currentDate - startDate).Days / 7;

            // Числитель для нечетных недель
            return weekNumber % 2 == 0;
        }

        /// <summary>
        /// Обработка выбора недели в ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WeekComboBox.SelectedIndex != -1)
            {
                var selectedWeek = _weeks[WeekComboBox.SelectedIndex];
                bool isNumerator = selectedWeek.IsNumerator;

                // Очищаем таблицы перед обновлением
                ClearTables();

                // Получаем расписание для выбранной недели
                if (_scheduleLoader.CurrentSchedule != null &&
                    _scheduleLoader.CurrentSchedule.Groups.TryGetValue(Program.userData.selectGroup, out var groupSchedule))
                {
                    FillSchedule(
                        MondayTLP, TuesdayTLP, WednesdayTLP,
                        ThursdayTLP, FridayTLP, SaturdayTLP,
                        groupSchedule, isNumerator);
                }
            }
        }

        /// <summary>
        /// Заполнение расписания в таблицах
        /// </summary>
        /// <param name="mondayTLP"></param>
        /// <param name="tuesdayTLP"></param>
        /// <param name="wednesdayTLP"></param>
        /// <param name="thursdayTLP"></param>
        /// <param name="fridayTLP"></param>
        /// <param name="saturdayTLP"></param>
        /// <param name="groupSchedule"></param>
        /// <param name="isNumerator"></param>
        public void FillSchedule(TableLayoutPanel mondayTLP, TableLayoutPanel tuesdayTLP,
                         TableLayoutPanel wednesdayTLP, TableLayoutPanel thursdayTLP,
                         TableLayoutPanel fridayTLP, TableLayoutPanel saturdayTLP,
                         GroupSchedule groupSchedule, bool isNumerator)
        {
            // Заполняем данные для каждого дня недели с учетом числителя/знаменателя
            FillDaySchedule(mondayTLP, groupSchedule.Monday, isNumerator);
            FillDaySchedule(tuesdayTLP, groupSchedule.Tuesday, isNumerator);
            FillDaySchedule(wednesdayTLP, groupSchedule.Wednesday, isNumerator);
            FillDaySchedule(thursdayTLP, groupSchedule.Thursday, isNumerator);
            FillDaySchedule(fridayTLP, groupSchedule.Friday, isNumerator);
            FillDaySchedule(saturdayTLP, groupSchedule.Saturday, isNumerator);
        }

        /// <summary>
        /// Очистка таблиц перед добавлением новых данных
        /// </summary>
        private void ClearTables()
        {
            ClearTable(MondayTLP);
            ClearTable(TuesdayTLP);
            ClearTable(WednesdayTLP);
            ClearTable(ThursdayTLP);
            ClearTable(FridayTLP);
            ClearTable(SaturdayTLP);
        }

        /// <summary>
        /// Очистка конкретной таблицы
        /// </summary>
        /// <param name="tableLayoutPanel"></param>
        private void ClearTable(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 0;
            tableLayoutPanel.RowStyles.Clear();
        }
        /// <summary>
        /// Заполняем расписание
        /// </summary>
        /// <param name="tableLayoutPanel"></param>
        /// <param name="daySchedule"></param>
        /// <param name="isNumerator"></param>
        private void FillDaySchedule(TableLayoutPanel tableLayoutPanel, DaySchedule daySchedule, bool isNumerator)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 0;
            tableLayoutPanel.RowStyles.Clear();

            // Создаем словарь для уроков по дням недели с учетом числителя и знаменателя для всех пар
            var lessons = new Dictionary<string, List<Lesson>>
            {
                { "I", GetLessonsForPeriod(daySchedule.I, isNumerator) },
                { "II", GetLessonsForPeriod(daySchedule.II, isNumerator) },
                { "III", GetLessonsForPeriod(daySchedule.III, isNumerator) },
                { "IV", GetLessonsForPeriod(daySchedule.IV, isNumerator) },
                { "V", GetLessonsForPeriod(daySchedule.V, isNumerator) },
            };

            // Добавляем уроки в таблицу
            foreach (var (lessonNumber, lessonList) in lessons)
            {
                if (lessonList != null && lessonList.Count > 0)
                {
                    foreach (var lesson in lessonList)
                    {
                        var task = !string.IsNullOrEmpty(lesson.Auditorium) ? $"Аудитория: {lesson.Auditorium}" : string.Empty;

                        // Добавляем строку в таблицу
                        AddRowToTable(tableLayoutPanel, lessonNumber, lesson.Name, lesson.Auditorium);
                    }
                }
            }
        }


        /// <summary>
        /// Для числителя берем первый элемент, для знаменателя второй
        /// Метод для получения уроков для числителя или знаменателя
        /// </summary>
        /// <param name="periodLessons"></param>
        /// <param name="isNumerator"></param>
        private List<Lesson>? GetLessonsForPeriod(List<Lesson> periodLessons, bool isNumerator)
        {
            // Если список пуст или null, возвращаем null
            if (periodLessons == null || periodLessons.Count < 2)
            {
                return null;
            }

            // Возвращаем соответствующий элемент в зависимости от isNumerator
            return new List<Lesson> { periodLessons[isNumerator ? 0 : 1] };
        }

        /// <summary>
        /// Добавление строк в таблицу
        /// </summary>
        /// <param name="tableLayoutPanel"></param>
        /// <param name="lessonNumber"></param>
        /// <param name="subject"></param>
        /// <param name="homework"></param>
        private static void AddRowToTable(TableLayoutPanel tableLayoutPanel, string lessonNumber, string subject, string homework)
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

        private void buttonUser_Click(object sender, EventArgs e)
        {
            // Показать меню рядом с кнопкой
            contextMenuStrip1.Show(buttonUser, new Point(0, buttonUser.Height));
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
