using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Note
{
    public partial class MainHomeworkForm : Form
    {
        public static ScheduleLoader _scheduleLoader = new ScheduleLoader();
        private List<Week> _weeks;

        public MainHomeworkForm()
        {
            InitializeComponent(); 
        }

        private async void MainHomeworkForm_Load(object sender, EventArgs e)
        {
            // Проверяем, авторизован ли пользователь
            if (Program.userData == null)
            {
                Program.ReplaceForm(Program.LogInForm, this);  // Переход на форму логина, если пользователь не авторизован
                return;
            }
            else
            {
                // Отрисовка имени пользователя в кнопке
                if (Program.userData.second_name != "" && Program.userData.second_name != null)
                    buttonUser.Text = Program.userData.last_name + " " + Program.userData.first_name.First() + "." + Program.userData.second_name.First() + ".";
                else
                    buttonUser.Text = Program.userData.last_name + " " + Program.userData.first_name;

                // Инициализация ContextMenuStrip для выпадающего списка для старосты и обычного студента
                contextMenuStrip1 = new ContextMenuStrip();
                contextMenuStrip1.Items.Add("Профиль", null, (s, e) => Program.ReplaceForm(Program.ProfileForm, this));  // Открытие профиля
                contextMenuStrip1.Items.Add("Уведомления", null, (s, e) => MessageBox.Show("Открыты уведомления"));  // Открытие уведомлений

                // Если пользователь является членом группы, добавляются дополнительные пункты в меню
                if (Program.userData.member_type)
                {
                    contextMenuStrip1.Items.Add("Группа", null, (s, e) => MessageBox.Show("Показаны участники группы"));  // Открытие группы
                    contextMenuStrip1.Items.Add("Добавить объявление", null, (s, e) => MessageBox.Show("Открыта форма добавления уведомления"));  // Открытие формы добавления объявления
                }
                contextMenuStrip1.Items.Add("Настройки", null, (s, e) => MessageBox.Show("Открыты настройки"));  // Открытие настроек
                contextMenuStrip1.Items.Add("Выйти", null, (s, e) => Application.Exit());  // Выход из приложения
            }

            // Проверяем, есть ли у пользователя выбранная группа
            if (Program.userData.selectGroup == null)
            {
                MessageBox.Show("У вас нет групп, пожалуйста присоединитесь");  // Сообщение, если группа не выбрана
                return;
            }

            // Загружаем расписание для выбранной группы
            await _scheduleLoader.GetScheduleAsync();
            try
            {
                // Проверяем, загружено ли расписание
                if (_scheduleLoader.CurrentSchedule != null &&
                    _scheduleLoader.CurrentSchedule.Groups.TryGetValue(Program.userData.selectGroup, out var groupSchedule))
                {
                    // Заполняем расписание для текущей недели
                    FillSchedule(
                        MondayTableLayoutPanel, TuesdayTableLayoutPanel, WednesdayTableLayoutPanel,
                        ThursdayTableLayoutPanel, FridayTableLayoutPanel, SaturdayTableLayoutPanel,
                        groupSchedule, GetCurrentWeekType());
                }
                else
                {
                    MessageBox.Show("Расписание не найдено.");  // Сообщение, если расписание не найдено
                }
            }
            catch
            {
                Program.ReplaceForm(Program.LogInForm, this);  // Перехід на форму логина в случае ошибки
            }

            // Устанавливаем даты начала и конца учебного года
            DateTime startDate = new DateTime(DateTime.Now.Year, 9, 2);
            DateTime endDate = new DateTime(DateTime.Now.Year + 1, 5, 31);
            _weeks = new List<Week>();
            int id = 0;
            bool isNumerator = true;

            // Создаем список недель с датами
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
                _weeks.Add(week);  // Добавляем неделю в список
                id++;
                isNumerator = !isNumerator;  // Переключаемся между числителем и знаменателем
            }

            // Добавляем недели в ComboBox
            foreach (var week in _weeks)
            {
                string weekString = $"{week.WeekNumber} неделя ({week.StartDate.ToShortDateString()} - {week.EndDate.ToShortDateString()})";
                WeekComboBox.Items.Add(weekString);  // Добавляем строку с номером недели в комбинированный список
            }

            // Определяем текущую неделю
            DateTime currentDate = DateTime.Now;
            int currentWeekId = 0;
            foreach (var week in _weeks)
            {
                if (currentDate >= week.StartDate && currentDate <= week.EndDate)
                {
                    currentWeekId = week.Id;
                    WeekComboBox.SelectedIndex = currentWeekId;  // Устанавливаем выбранную неделю
                    break;
                }
            }
            if (WeekComboBox.SelectedIndex != -1)
            {
                var currentWeek = _weeks[WeekComboBox.SelectedIndex];
                UpdateWeekDayLabels(currentWeek);  // Обновляем метки дней недели для текущей недели
            }
        }

        // Метод для получения типа недели (числитель или знаменатель)
        private bool GetCurrentWeekType()
        {
            var startDate = new DateTime(DateTime.Now.Year, 9, 2);
            var currentDate = DateTime.Now;
            var weekNumber = (currentDate - startDate).Days / 7;
            return weekNumber % 2 == 0;  // Четные недели - числитель, нечетные - знаменатель
        }

        // Обработчик выбора недели в комбинированном списке
        private void WeekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WeekComboBox.SelectedIndex != -1)
            {
                var selectedWeek = _weeks[WeekComboBox.SelectedIndex];
                UpdateWeekDayLabels(selectedWeek);  // Обновляем метки с датами
                ClearTables();  // Очищаем таблицы перед заполнением новыми данными

                // Заполняем таблицы с расписанием для выбранной недели
                if (_scheduleLoader.CurrentSchedule != null &&
                    _scheduleLoader.CurrentSchedule.Groups.TryGetValue(Program.userData.selectGroup, out var groupSchedule))
                {
                    FillSchedule(
                        MondayTableLayoutPanel, TuesdayTableLayoutPanel, WednesdayTableLayoutPanel,
                        ThursdayTableLayoutPanel, FridayTableLayoutPanel, SaturdayTableLayoutPanel,
                        groupSchedule, selectedWeek.IsNumerator);
                }
            }
        }

        // Обновляем метки с датами для выбранной недели
        private void UpdateWeekDayLabels(Week selectedWeek)
        {
            if (selectedWeek != null)
            {
                MondayDateLabel.Text = selectedWeek.StartDate.ToString("dd.MM");  // Понеделник
                TuesdayDateLabel.Text = selectedWeek.StartDate.AddDays(1).ToString("dd.MM");  // Вторник
                WednesdayDateLabel.Text = selectedWeek.StartDate.AddDays(2).ToString("dd.MM");  // Среда
                ThursdayDateLabel.Text = selectedWeek.StartDate.AddDays(3).ToString("dd.MM");  // Четверг
                FridayDateLabel.Text = selectedWeek.StartDate.AddDays(4).ToString("dd.MM");  // Пятница
                SaturdayDateLabel.Text = selectedWeek.StartDate.AddDays(5).ToString("dd.MM");  // Суббота
            }
        }

        // Заполняем расписание для всей недели
        public void FillSchedule(TableLayoutPanel mondayTLP, TableLayoutPanel tuesdayTLP,
                         TableLayoutPanel wednesdayTLP, TableLayoutPanel thursdayTLP,
                         TableLayoutPanel fridayTLP, TableLayoutPanel saturdayTLP,
                         GroupSchedule groupSchedule, bool isNumerator)
        {
            FillDaySchedule(mondayTLP, groupSchedule.Monday, isNumerator);  // Понедельник
            FillDaySchedule(tuesdayTLP, groupSchedule.Tuesday, isNumerator);  // Вторник
            FillDaySchedule(wednesdayTLP, groupSchedule.Wednesday, isNumerator);  // Среда
            FillDaySchedule(thursdayTLP, groupSchedule.Thursday, isNumerator);  // Четверг
            FillDaySchedule(fridayTLP, groupSchedule.Friday, isNumerator);  // Пятница
            FillDaySchedule(saturdayTLP, groupSchedule.Saturday, isNumerator);  // Суббота
        }

        // Очищаем таблицы расписания
        private void ClearTables()
        {
            ClearTable(MondayTableLayoutPanel);  // Очищаем понедельник
            ClearTable(TuesdayTableLayoutPanel);  // Очищаем вторник
            ClearTable(WednesdayTableLayoutPanel);  // Очищаем среду
            ClearTable(ThursdayTableLayoutPanel);  // Очищаем четверг
            ClearTable(FridayTableLayoutPanel);  // Очищаем пятницу
            ClearTable(SaturdayTableLayoutPanel);  // Очищаем субботу
        }

        // Очищаем одну таблицу
        private void ClearTable(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.Controls.Clear();  // Удаляем все элементы управления из таблицы
            tableLayoutPanel.RowCount = 0;  // Сбрасываем количество строк
            tableLayoutPanel.RowStyles.Clear();  // Очищаем стили строк
        }

        // Заполняем таблицу для одного дня
        private void FillDaySchedule(TableLayoutPanel tableLayoutPanel, DaySchedule daySchedule, bool isNumerator)
        {
            tableLayoutPanel.Controls.Clear();  // Очищаем таблицу
            tableLayoutPanel.RowCount = 0;  // Сбрасываем количество строк
            tableLayoutPanel.RowStyles.Clear();  // Очищаем стили строк

            // Создаем словарь для пар по дням недели с учетом числителя и знаменателя для всех пар
            var lessons = new Dictionary<string, List<Lesson>>
            {
                { "I", GetLessonsForPeriod(daySchedule.I, isNumerator) },
                { "II", GetLessonsForPeriod(daySchedule.II, isNumerator) },
                { "III", GetLessonsForPeriod(daySchedule.III, isNumerator) },  
                { "IV", GetLessonsForPeriod(daySchedule.IV, isNumerator) }, 
                { "V", GetLessonsForPeriod(daySchedule.V, isNumerator) }, 
                { "I - B", GetLessonsForPeriod(daySchedule.I_V, isNumerator) },  
                { "II - B", GetLessonsForPeriod(daySchedule.II_V, isNumerator) }, 
            };

            // Добавляем пары в таблицу
            foreach (var (lessonNumber, lessonList) in lessons)
            {
                if (lessonList != null && lessonList.Count > 0)
                {
                    foreach (var lesson in lessonList)
                    {
                        AddRowToTable(tableLayoutPanel, lessonNumber, lesson.Name, lesson.Auditorium);  // Добавляем строку с данными пары
                    }
                }
            }
        }

        // Получаем пары для конкретного периода (числитель или знаменатель)
        private List<Lesson>? GetLessonsForPeriod(List<Lesson> periodLessons, bool isNumerator)
        {
            if (periodLessons == null || periodLessons.Count < 2)
            {
                return null;  // Если пар нет или недостаточно, возвращаем null
            }

            return new List<Lesson> { periodLessons[isNumerator ? 0 : 1] };  // Возвращаем пару для числителя или знаменателя
        }

        // Добавляем строку с данными пары в таблицу
        private static void AddRowToTable(TableLayoutPanel tableLayoutPanel, string lessonNumber, string subject, string homework)
        {
            var lblNumber = new Label
            {
                Text = lessonNumber,  // Номер пары
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 14F),
                AutoSize = true,
                MaximumSize = new Size(0, 0),
            };

            var lblSubject = new Label
            {
                Text = subject,  // Название предмета
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 14F),
                AutoSize = true,
                MaximumSize = new Size(0, 0),
            };

            var lblHomework = new Label
            {
                Text = homework,  // Домашнее задание
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 14F),
                AutoSize = true,
                MaximumSize = new Size(0, 0),
            };

            // Добавляем данные в таблицу
            tableLayoutPanel.RowCount += 1;  // Увеличиваем количество строк в таблице
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // Добавляем стиль для строки
            tableLayoutPanel.Controls.Add(lblNumber, 0, tableLayoutPanel.RowCount - 1);  // Номер урока в первый столбец
            tableLayoutPanel.Controls.Add(lblSubject, 1, tableLayoutPanel.RowCount - 1);  // Название предмета во второй столбец
            tableLayoutPanel.Controls.Add(lblHomework, 2, tableLayoutPanel.RowCount - 1);  // Домашнее задание в третий столбец
        }

        // Обработчик нажатия на кнопку "Пользователь"
        private void buttonUser_Click(object sender, EventArgs e)
        {
            // Показываем контекстное меню
            contextMenuStrip1.Show(buttonUser, new Point(0, buttonUser.Height));
        }
    }
}
