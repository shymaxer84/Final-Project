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
    public partial class ChoiсeForm : Form
    {
        String Choose;
        public ChoiсeForm()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {


            // string Atrada = "מניעה להטרדה מינית";
            // string Tikva = " רב תרבותיות";
            switch (Choose)
            {
                case "מניעת הטרדה מינית":
                    // this.Close();
                    // ReportForm form = new ReportForm();
                    // form.Show();  
                 
                    ReportForm form = new ReportForm();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                    break;


                case "רב תרבותיות":

                    // this.Close();
                    // ReportForm2 form2 = new ReportForm2();
                    // form2.Show();
                    ReportForm2 form2 = new ReportForm2();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                    break;

                default:
                   
                 MessageBox.Show("Choose Your Report Please", "Report Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 break;
                    





                      

            }

           
           
            
                

            
           
                

            
        }

        private void BtnLogOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CbxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choose = CbxChoice.SelectedItem.ToString();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm Welcome = new WelcomeForm();
            Welcome.ShowDialog();
            this.Close();
        }
    }
}
