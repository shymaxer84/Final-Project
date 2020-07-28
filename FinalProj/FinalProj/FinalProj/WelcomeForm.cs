using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void RegClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm regform = new RegisterForm();
            regform.Show();
            //this.Close();
        }

        private void LogClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Logform = new LoginForm();
            Logform.ShowDialog();
            //this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
