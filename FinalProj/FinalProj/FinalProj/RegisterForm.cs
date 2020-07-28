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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void TxtFirstName_Enter(object sender, EventArgs e)
        {

            string fname = TxtFirstName.Text;
            if (fname.ToLower().Trim().Equals("שם פרטי"))
            {
                TxtFirstName.Text = "";
                TxtFirstName.ForeColor = Color.Black;
            }
        }

        private void TxtFirstName_Leave(object sender, EventArgs e)
        {
            string fname = TxtFirstName.Text;
            if (fname.ToLower().Trim().Equals("שם פרטי") || fname.Trim().Equals(""))
            {
                TxtFirstName.Text = "שם פרטי";
                TxtFirstName.ForeColor = Color.Gray;
            }
        }

        private void TxtLastName_Enter(object sender, EventArgs e)
        {

            string lname = TxtLastName.Text;
            if (lname.ToLower().Trim().Equals("שם משפחה"))
            {
                TxtLastName.Text = "";
                TxtLastName.ForeColor = Color.Black;
            }
        }

        private void TxtLastName_Leave(object sender, EventArgs e)
        {
            string lname = TxtLastName.Text;
            if (lname.ToLower().Trim().Equals("שם משפחה") || lname.Trim().Equals(""))
            {
                TxtLastName.Text = "שם משפחה";
                TxtLastName.ForeColor = Color.Gray;
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            if (email.ToLower().Trim().Equals("דואר אלקטרוני"))
            {
                TxtEmail.Text = "";
                TxtEmail.ForeColor = Color.Black;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            if (email.ToLower().Trim().Equals("דואר אלקטרוני") || email.Trim().Equals(""))
            {
                TxtEmail.Text = "דואר אלקטרוני";
                TxtEmail.ForeColor = Color.Gray;
            }
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            string username = TxtUserName.Text;
            if (username.ToLower().Trim().Equals("שם משתמש"))
            {
                TxtUserName.Text = "";
                TxtUserName.ForeColor = Color.Black;
            }
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            string username = TxtUserName.Text;
            if (username.ToLower().Trim().Equals("שם משתמש") || username.Trim().Equals(""))
            {
                TxtUserName.Text = "שם משתמש";
                TxtUserName.ForeColor = Color.Gray;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            string password = TxtPassword.Text;
            if (password.ToLower().Trim().Equals("סיסמא"))
            {
                TxtPassword.Text = "";
                TxtPassword.UseSystemPasswordChar = true;
                TxtPassword.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            string password = TxtPassword.Text;
            if (password.ToLower().Trim().Equals("סיסמא") || password.Trim().Equals(""))
            {
                TxtPassword.Text = "סיסמא";
                TxtPassword.UseSystemPasswordChar = false;
                TxtPassword.ForeColor = Color.Gray;
            }
        }

        private void TxtRePassword_Enter(object sender, EventArgs e)
        {
            string cpassword = TxtRePassword.Text;
            if (cpassword.ToLower().Trim().Equals("סיסמא שנית"))
            {
                TxtRePassword.Text = "";
                TxtRePassword.UseSystemPasswordChar = true;
                TxtRePassword.ForeColor = Color.Black;
            }
        }

        private void TxtRePassword_Leave(object sender, EventArgs e)
        {
            string cpassword = TxtRePassword.Text;
            if (cpassword.ToLower().Trim().Equals("סיסמא שנית") || cpassword.Trim().Equals(""))
            {
                TxtRePassword.Text = "סיסמא שנית";
                TxtRePassword.UseSystemPasswordChar = false;
                TxtRePassword.ForeColor = Color.Gray;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`firstname`, `lastname`, `emailaddress`, `username`, `password`) VALUES(@fn, @ln ,@email, @usn, @pass)", db.GetConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = TxtFirstName.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = TxtLastName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = TxtEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TxtUserName.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TxtPassword.Text;

            // open the connection
            db.openConnection();
            // check if the boxes containts the deafult values
            if (!CheckTextBoxesValues())
            {
                //check if the password equql the confirm password
                if (TxtPassword.Text.Equals(TxtRePassword.Text))
                {
                    // check if the username already exists
                    if (CheckUsername())
                    {
                        MessageBox.Show("This Username Already Exist, Select a diffrent one", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            LoginForm  choice = new LoginForm();
                            choice.Show();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Wrong Comfirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Enter Your Information First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }




            //close connection
            db.closeConnection();



        }
        //check if username already exist
        public bool CheckUsername()
        {

            DB db = new DB();

            string username = TxtUserName.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE username = @usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Check if the username already exists on database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //check if the textsboxes contains the default values
        public bool CheckTextBoxesValues()
        {
            string fname = TxtFirstName.Text;
            string lname = TxtLastName.Text;
            string email = TxtEmail.Text;
            string uname = TxtUserName.Text;
            string pass = TxtPassword.Text;

            if (fname.Equals("שם פרטי") || lname.Equals("שם משפחה") || email.Equals("דואר אלקטרוני") || uname.Equals("שם משתמש") || pass.Equals("סיסמא"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void ClickHere_Enter(object sender, EventArgs e)
        {
            ClickHere.ForeColor = Color.Yellow;
        }

        private void ClickHere_Leave(object sender, EventArgs e)
        {
            ClickHere.ForeColor = Color.White;
        }

        private void ClickHere_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
    
}

