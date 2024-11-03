using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Note;

namespace Student_Note
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void LogUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ReplaceForm(new LogInForm(), this);
        }
    }
}
