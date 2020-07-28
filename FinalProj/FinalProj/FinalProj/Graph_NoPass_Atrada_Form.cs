using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalProj
{
    public partial class Graph_NoPass_Atrada_Form : Form
    {
        public Graph_NoPass_Atrada_Form()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port = 3308;username=root;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand sqlCommand = new MySqlCommand("SELECT Name, Result FROM `progress theachers`.atrada where Result < 80; ", conDataBase);

            MySqlDataReader myreader;
            try
            {
                conDataBase.Open();

                myreader = sqlCommand.ExecuteReader();

                while (myreader.Read())
                {
                    this.chart1.Series["ציוני נכשלים"].Points.AddXY(myreader.GetString("Name"),
                                                            myreader.GetString("Result"));

                }


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
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

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChoiсeForm Choice = new ChoiсeForm();
            Choice.ShowDialog();
            this.Close();
        }

        private void BtnBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm rep1 = new ReportForm();
            rep1.ShowDialog();
            this.Close();
        }
    }
}
