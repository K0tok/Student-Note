using Microsoft.VisualBasic.ApplicationServices;

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
        static public void ReplaceForm(Form newForm, Form oldForm)
        {
            // ������� ������� (�������) �����
            newForm.FormClosed += (s, args) => oldForm.Close();
            // �������� ������ �����
            newForm.Show();
            oldForm.Hide();
        }

        static Form MainForm = new MainForm();
        static public bool isLog = false;
    }
}