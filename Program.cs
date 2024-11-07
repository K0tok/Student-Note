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

        static public Form MainForm = new MainForm();
        static public Form LogInForm = new LogInForm();
        static public void ReplaceForm(Form newForm, Form oldForm)
        {
            // Закрыть текущую (главную) форму
            newForm.FormClosed += (s, args) => oldForm.Close();
            // Показать вторую форму
            newForm.Show();
            oldForm.Hide();
        }

        static public bool isLog = false;
        
    }
}