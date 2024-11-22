using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Student_Note
{
    public partial class MakeHomework : Form
    {
        public MakeHomework()
        {
            InitializeComponent();

            SelectNumberLesson.DataSource = new List<string>{"1", "2", "3", "4", "5", "1-B", "2-B"};
            SelectLesson.DataSource = new List<string> { "Математика", "Не математика"};
            TextHomework.Text = "StartHomeWork";
            SelectDate.Value = new DateTime(2001, 10, 20);
        }
        private string Lesson;
        private string NumberLesson;
        private string textHomework;
        private DateTime Date;
        private void SaveHomework_Click(object sender, EventArgs e)
        {

        }
    }
}
