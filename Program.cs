using Microsoft.VisualBasic.ApplicationServices;
using Student_Note;

namespace Student_Note
{
    internal static class Program
    {

        [STAThread]
        static public void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(LogInForm);
        }
        /// <summary>
        /// Данные пользователя
        /// </summary>
        static public UserData userData;

        static public Form MainForm = new MainForm();
        static public Form LogInForm = new LogInForm();
        static public Form SignUpForm = new SignUpForm();
        static public Form MakeHomework = new MakeHomework();
        static public Form AddGroupForm = new AddGroupForm();
        /// <summary>
        /// Список посещений форм
        /// </summary>
        static public List<Form> formsHistory = new List<Form>();

        /// <summary>
        /// Меняет форму на newForm из oldForm
        /// </summary>
        static public void ReplaceForm(Form newForm, Form oldForm)
        {
            // Обработка истории переключения форм 
            if (formsHistory.Contains(newForm)) 
            { 
                formsHistory.RemoveAt(formsHistory.IndexOf(newForm));
                formsHistory.Add(newForm);
            }
            else
            {
                formsHistory.Add(newForm);
            }
            
            newForm.FormClosed += (s, args) => oldForm.Close();
            newForm.Show();
            oldForm.Hide();
        }

        static public bool isLog = false;

        public static string relativePath = @"Student Note.db";
        public static string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
    }
}