using Microsoft.VisualBasic.ApplicationServices;

namespace Student_Note
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LogInForm());
            //MainForm form = new MainForm();
        }
    }
}