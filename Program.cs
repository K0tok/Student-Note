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
            Application.Run(MainForm);
        }

        static public Form MainForm = new MainForm();
        static public Form LogInForm = new LogInForm();
        static public Form SignUpForm = new SignUpForm();
        static public void ReplaceForm(Form newForm, Form oldForm)
        {
            newForm.FormClosed += (s, args) => oldForm.Close();
            newForm.Show();
            oldForm.Hide();
        }

        static public bool isLog = false;

        public static string relativePath = @"Student Note.db";
        public static string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
    }
}