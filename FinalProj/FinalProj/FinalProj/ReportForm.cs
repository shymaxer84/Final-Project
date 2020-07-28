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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

        }
        

        private void BtnRepShow1_Click(object sender, EventArgs e)
        {
           // ReportForm report = new ReportForm();
            string constring = "datasource=localhost;port = 3308;username=root;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataAdapter DB = new MySqlDataAdapter("SELECT Name,Result FROM `progress theachers`.atrada where Result >= 80;", conDataBase);

            conDataBase.Open();
            DataSet db = new DataSet();
            DB.Fill(db, "atrada");
            ReportForm report = new ReportForm();
            this.Hide();
            report.DataGridView.DataSource = db.Tables["atrada"];
            report.ShowDialog();
            this.Close();



            conDataBase.Close();
            this.Close();
            ReportForm form = new ReportForm();
            form.Show();

        }

        private void BtnRepShow2_Click(object sender, EventArgs e)
        {
           // ReportForm report = new ReportForm();
            string constring = "datasource=localhost;port = 3308;username=root;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataAdapter DB = new MySqlDataAdapter("SELECT Name, Result FROM `progress theachers`.atrada where Result < 80 ; ", conDataBase);

            conDataBase.Open();
            DataSet db = new DataSet();
            DB.Fill(db, "atrada");
            ReportForm report = new ReportForm();
            this.Hide();
            report.DataGridView.DataSource = db.Tables["atrada"];
            report.ShowDialog();
            this.Close();

            conDataBase.Close();
            this.Close();
            ReportForm form = new ReportForm();
            form.Show();
        }

        private void BtnRepShow3_Click(object sender, EventArgs e)
        {
            //ReportForm report = new ReportForm();
            string constring = "datasource=localhost;port = 3308;username=root;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataAdapter DB = new MySqlDataAdapter("SELECT name , Hatrada_Achva_2019 FROM `progress theachers`.atrada where Hatrada_Achva_2019 = 'התחיל וטרם הסתיים';", conDataBase);

            conDataBase.Open();
            DataSet db = new DataSet();
            DB.Fill(db, "atrada");
            ReportForm report = new ReportForm();
            this.Hide();
            report.DataGridView.DataSource = db.Tables["atrada"];
            report.ShowDialog();
            this.Close();

            conDataBase.Close();
            this.Close();
            ReportForm form = new ReportForm();
            form.Show();
        }

        private void BtnRepShow4_Click(object sender, EventArgs e)
        {
            //ReportForm report = new ReportForm();
            string constring = "datasource=localhost;port = 3308;username=root;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataAdapter DB = new MySqlDataAdapter("SELECT Name,Start,Finish FROM `progress theachers`.atrada;", conDataBase);

            conDataBase.Open();
            DataSet db = new DataSet();
            DB.Fill(db, "atrada");
            ReportForm report = new ReportForm();
            this.Hide();
            report.DataGridView.DataSource = db.Tables["atrada"];
            report.ShowDialog();
            this.Close();

            conDataBase.Close();
            this.Close();
            ReportForm form = new ReportForm();
            form.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port = 3308;username=root;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            //this.Close();
            conDataBase.Close();
            ChoiсeForm choice = new ChoiсeForm();
            this.Hide();
            choice.ShowDialog();
            this.Close();
        }

        private void BtnLogOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PassGraphBox_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port = 3308;username=root;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            conDataBase.Open();
           // this.Close();
            Graph_Pass_Atrada_Form graph = new Graph_Pass_Atrada_Form();
            this.Hide();
            graph.ShowDialog();
            this.Close();

            conDataBase.Close();
           // this.Close();
            ReportForm report = new ReportForm();
            this.Close();
            report.ShowDialog();
        }

        private void NotPassGraphBox_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port = 3308;username=root;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            conDataBase.Open();
          //  this.Close();
            Graph_NoPass_Atrada_Form graph = new Graph_NoPass_Atrada_Form();
            this.Hide();
            graph.ShowDialog();
            this.Close();

            conDataBase.Close();
            this.Close();
            ReportForm report = new ReportForm();
            report.ShowDialog();
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
