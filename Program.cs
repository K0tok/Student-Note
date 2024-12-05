using Microsoft.VisualBasic.ApplicationServices;
using Student_Note;
using Student_Note.Menu;
using System.Text;

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
        static public UserData? userData;

        static public Form MainHomeworkForm = new MainHomeworkForm();
        static public Form LogInForm        = new LogInForm();
        static public Form SignUpForm       = new SignUpForm();
        static public Form MakeHomeworkForm = new MakeHomework();
        static public Form AddGroupForm     = new AddGroupForm();
        /// MENU
        static public Form ProfileForm      = new ProfileForm();
        static public Form SettingsForm     = new SettingsForm();
        /// <summary>
        /// Меняет форму на newForm из oldForm
        /// </summary>
        static public void ReplaceForm(Form newForm, Form oldForm)
        {
            bool isClosingOldForm = false;

            try
            {
                newForm.FormClosed += (s, args) =>
                {
                    if (!isClosingOldForm)
                    {
                        isClosingOldForm = true;
                        oldForm.Close();
                    }
                };

                newForm.Show();
                oldForm.Hide();
            }
            catch
            {
                Application.Exit();
            }
        }

        static public bool isLog = false;

        public static string relativePath = @"Student Note.db";
        public static string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
    }
}