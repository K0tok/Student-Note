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
            newForm.FormClosed += (s, args) => oldForm.Close();
            newForm.Show();
            oldForm.Hide();

            //закрытие БД
            if (Data_Base.sqliteConnect != null && Data_Base.sqliteConnect.State == System.Data.ConnectionState.Open)
            {
                Data_Base.sqliteConnect.Close();
                MessageBox.Show("Соединение закрыто.");
            }
        }

        static public bool isLog = false;
        
    }
}