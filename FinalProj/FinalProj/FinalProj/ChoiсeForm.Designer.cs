namespace FinalProj
{
    partial class ChoiсeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiсeForm));
            this.Line1 = new System.Windows.Forms.Label();
            this.ChoiceTitle = new System.Windows.Forms.Label();
            this.CbxChoice = new System.Windows.Forms.ComboBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LogOffBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Line1
            // 
            this.Line1.AutoSize = true;
            this.Line1.BackColor = System.Drawing.Color.Transparent;
            this.Line1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Line1.Location = new System.Drawing.Point(262, 240);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(718, 37);
            this.Line1.TabIndex = 2;
            this.Line1.Text = "שלום, על מנת להפיק דוחות טבלאיות, עליך לבחור באחת הלומדות";
            // 
            // ChoiceTitle
            // 
            this.ChoiceTitle.AutoSize = true;
            this.ChoiceTitle.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceTitle.Font = new System.Drawing.Font("Arial Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ChoiceTitle.Location = new System.Drawing.Point(681, 169);
            this.ChoiceTitle.Name = "ChoiceTitle";
            this.ChoiceTitle.Size = new System.Drawing.Size(213, 45);
            this.ChoiceTitle.TabIndex = 1;
            this.ChoiceTitle.Text = "בחירת לומדה";
            // 
            // CbxChoice
            // 
            this.CbxChoice.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxChoice.FormattingEnabled = true;
            this.CbxChoice.Items.AddRange(new object[] {
            "מניעת הטרדה מינית",
            "רב תרבותיות"});
            this.CbxChoice.Location = new System.Drawing.Point(489, 349);
            this.CbxChoice.Name = "CbxChoice";
            this.CbxChoice.Size = new System.Drawing.Size(300, 45);
            this.CbxChoice.TabIndex = 3;
            this.CbxChoice.SelectedIndexChanged += new System.EventHandler(this.CbxChoice_SelectedIndexChanged);
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSend.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.ForeColor = System.Drawing.Color.White;
            this.BtnSend.Location = new System.Drawing.Point(514, 454);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(165, 71);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "הפק דוחות";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // LogOffBtn
            // 
            this.LogOffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LogOffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOffBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOffBtn.ForeColor = System.Drawing.Color.White;
            this.LogOffBtn.Location = new System.Drawing.Point(158, 58);
            this.LogOffBtn.Name = "LogOffBtn";
            this.LogOffBtn.Size = new System.Drawing.Size(140, 51);
            this.LogOffBtn.TabIndex = 6;
            this.LogOffBtn.Text = "התנתקות";
            this.LogOffBtn.UseVisualStyleBackColor = false;
            this.LogOffBtn.Click += new System.EventHandler(this.LogOffBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(54, 58);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(98, 51);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "סגירה";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ChoiсeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LogOffBtn);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.CbxChoice);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.ChoiceTitle);
            this.Name = "ChoiсeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "בחירת לומדה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label ChoiceTitle;
        private System.Windows.Forms.ComboBox CbxChoice;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button LogOffBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}