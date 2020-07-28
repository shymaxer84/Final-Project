namespace FinalProj
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.RePassword = new System.Windows.Forms.Label();
            this.RegistrationTitle = new System.Windows.Forms.Label();
            this.Line1 = new System.Windows.Forms.Label();
            this.ClickHere = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtRePassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Transparent;
            this.FirstName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FirstName.Location = new System.Drawing.Point(594, 205);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(81, 26);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "שם פרטי";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.Color.Transparent;
            this.LastName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LastName.Location = new System.Drawing.Point(571, 240);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(104, 26);
            this.LastName.TabIndex = 8;
            this.LastName.Text = "שם משפחה";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Email.Location = new System.Drawing.Point(615, 273);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(60, 26);
            this.Email.TabIndex = 10;
            this.Email.Text = "אימייל";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UserName.Location = new System.Drawing.Point(567, 308);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(108, 26);
            this.UserName.TabIndex = 12;
            this.UserName.Text = "שם משתמש";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Password.Location = new System.Drawing.Point(611, 346);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(64, 26);
            this.Password.TabIndex = 14;
            this.Password.Text = "סיסמא";
            // 
            // RePassword
            // 
            this.RePassword.AutoSize = true;
            this.RePassword.BackColor = System.Drawing.Color.Transparent;
            this.RePassword.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RePassword.Location = new System.Drawing.Point(567, 382);
            this.RePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(108, 26);
            this.RePassword.TabIndex = 16;
            this.RePassword.Text = "סיסמא שנית";
            // 
            // RegistrationTitle
            // 
            this.RegistrationTitle.AutoSize = true;
            this.RegistrationTitle.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationTitle.Font = new System.Drawing.Font("Arial Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RegistrationTitle.Location = new System.Drawing.Point(502, 105);
            this.RegistrationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationTitle.Name = "RegistrationTitle";
            this.RegistrationTitle.Size = new System.Drawing.Size(239, 31);
            this.RegistrationTitle.TabIndex = 1;
            this.RegistrationTitle.Text = "טופס הרשמה למערכת";
            // 
            // Line1
            // 
            this.Line1.AutoSize = true;
            this.Line1.BackColor = System.Drawing.Color.Transparent;
            this.Line1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Line1.Location = new System.Drawing.Point(223, 151);
            this.Line1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(600, 26);
            this.Line1.TabIndex = 2;
            this.Line1.Text = "שלום, על מנת להשתמש במערכת, עליך להירשם. במידה ויש לך כבר משתמש";
            // 
            // ClickHere
            // 
            this.ClickHere.AutoSize = true;
            this.ClickHere.BackColor = System.Drawing.Color.Transparent;
            this.ClickHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickHere.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClickHere.Location = new System.Drawing.Point(142, 151);
            this.ClickHere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClickHere.Name = "ClickHere";
            this.ClickHere.Size = new System.Drawing.Size(83, 26);
            this.ClickHere.TabIndex = 3;
            this.ClickHere.Text = "לחץ כאן";
            this.ClickHere.Click += new System.EventHandler(this.ClickHere_Click);
            this.ClickHere.Enter += new System.EventHandler(this.ClickHere_Enter);
            this.ClickHere.Leave += new System.EventHandler(this.ClickHere_Leave);
            // 
            // Line2
            // 
            this.Line2.AutoSize = true;
            this.Line2.BackColor = System.Drawing.Color.Transparent;
            this.Line2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Line2.Location = new System.Drawing.Point(69, 151);
            this.Line2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(79, 26);
            this.Line2.TabIndex = 4;
            this.Line2.Text = "להתחבר";
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSend.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.ForeColor = System.Drawing.Color.White;
            this.BtnSend.Location = new System.Drawing.Point(124, 262);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(110, 46);
            this.BtnSend.TabIndex = 18;
            this.BtnSend.Text = "הירשם";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtFirstName.Location = new System.Drawing.Point(305, 204);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFirstName.Multiline = true;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(253, 27);
            this.TxtFirstName.TabIndex = 7;
            this.TxtFirstName.Text = "שם פרטי";
            this.TxtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtFirstName.Enter += new System.EventHandler(this.TxtFirstName_Enter);
            this.TxtFirstName.Leave += new System.EventHandler(this.TxtFirstName_Leave);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtLastName.Location = new System.Drawing.Point(305, 239);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLastName.Multiline = true;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(253, 27);
            this.TxtLastName.TabIndex = 9;
            this.TxtLastName.Text = "שם משפחה";
            this.TxtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtLastName.Enter += new System.EventHandler(this.TxtLastName_Enter);
            this.TxtLastName.Leave += new System.EventHandler(this.TxtLastName_Leave);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtEmail.Location = new System.Drawing.Point(305, 273);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(253, 27);
            this.TxtEmail.TabIndex = 11;
            this.TxtEmail.Text = "דואר אלקטרוני";
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtPassword.Location = new System.Drawing.Point(305, 343);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(253, 32);
            this.TxtPassword.TabIndex = 15;
            this.TxtPassword.Text = "סיסמא";
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtRePassword
            // 
            this.TxtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRePassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtRePassword.Location = new System.Drawing.Point(305, 379);
            this.TxtRePassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRePassword.Name = "TxtRePassword";
            this.TxtRePassword.Size = new System.Drawing.Size(253, 32);
            this.TxtRePassword.TabIndex = 17;
            this.TxtRePassword.Text = "סיסמא שנית";
            this.TxtRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRePassword.UseSystemPasswordChar = true;
            this.TxtRePassword.Enter += new System.EventHandler(this.TxtRePassword_Enter);
            this.TxtRePassword.Leave += new System.EventHandler(this.TxtRePassword_Leave);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtUserName.Location = new System.Drawing.Point(305, 308);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserName.Multiline = true;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(253, 27);
            this.TxtUserName.TabIndex = 13;
            this.TxtUserName.Text = "שם משתמש";
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            this.TxtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(36, 38);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(65, 33);
            this.CloseBtn.TabIndex = 19;
            this.CloseBtn.Text = "סגירה";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(361, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "כל הטופס נדרש למילוי*";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtRePassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.ClickHere);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.RegistrationTitle);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "הרשמה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label RePassword;
        private System.Windows.Forms.Label RegistrationTitle;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label ClickHere;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtRePassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
    }
}

