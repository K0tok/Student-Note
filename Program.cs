using Microsoft.VisualBasic.ApplicationServices;

namespace Student_Note
{
    internal static class Program
    {
        [STAThread]
        static public void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LogInForm());
            // MainForm form = new MainForm();
        }
        static public void ReplaceForm(Form form)
        {
            form.Show();
        }
    }
}