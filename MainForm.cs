using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Note
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private /*async*/ void MainForm_Load(object sender, EventArgs e)
        {
            // Вызов функции, которая загрузит и выведет данные
            //await new Data_Base().GetScheduleAsync();
        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
