namespace FinalProj
{
    partial class Graph_Pass_Tarbut_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph_Pass_Tarbut_Form));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReportTitle = new System.Windows.Forms.Label();
            this.BtnBack2 = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LogOffBtn = new System.Windows.Forms.Button();
            this.BtnBack1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(60, 222);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "ציוני עוברים";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1106, 489);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // ReportTitle
            // 
            this.ReportTitle.AutoSize = true;
            this.ReportTitle.BackColor = System.Drawing.Color.Transparent;
            this.ReportTitle.Font = new System.Drawing.Font("Arial Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ReportTitle.Location = new System.Drawing.Point(336, 149);
            this.ReportTitle.Name = "ReportTitle";
            this.ReportTitle.Size = new System.Drawing.Size(888, 45);
            this.ReportTitle.TabIndex = 1;
            this.ReportTitle.Text = "תצוגה גרפית של ציונים עוברים עבור הלומדה לרב תרבותיות";
            // 
            // BtnBack2
            // 
            this.BtnBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack2.ForeColor = System.Drawing.Color.White;
            this.BtnBack2.Location = new System.Drawing.Point(576, 58);
            this.BtnBack2.Name = "BtnBack2";
            this.BtnBack2.Size = new System.Drawing.Size(267, 51);
            this.BtnBack2.TabIndex = 6;
            this.BtnBack2.Text = "חזרה לבחירת דוחות";
            this.BtnBack2.UseVisualStyleBackColor = false;
            this.BtnBack2.Click += new System.EventHandler(this.BtnBack2_Click);
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
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "סגירה";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
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
            this.LogOffBtn.TabIndex = 4;
            this.LogOffBtn.Text = "התנתקות";
            this.LogOffBtn.UseVisualStyleBackColor = false;
            this.LogOffBtn.Click += new System.EventHandler(this.LogOffBtn_Click);
            // 
            // BtnBack1
            // 
            this.BtnBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack1.ForeColor = System.Drawing.Color.White;
            this.BtnBack1.Location = new System.Drawing.Point(303, 58);
            this.BtnBack1.Name = "BtnBack1";
            this.BtnBack1.Size = new System.Drawing.Size(267, 51);
            this.BtnBack1.TabIndex = 5;
            this.BtnBack1.Text = "חזרה לבחירת לומדה";
            this.BtnBack1.UseVisualStyleBackColor = false;
            this.BtnBack1.Click += new System.EventHandler(this.BtnBack1_Click);
            // 
            // Graph_Pass_Tarbut_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BtnBack2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LogOffBtn);
            this.Controls.Add(this.BtnBack1);
            this.Controls.Add(this.ReportTitle);
            this.Controls.Add(this.chart1);
            this.Name = "Graph_Pass_Tarbut_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "גרף עוברים - לומדה לרב תרבותיות";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label ReportTitle;
        private System.Windows.Forms.Button BtnBack2;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button LogOffBtn;
        private System.Windows.Forms.Button BtnBack1;
    }
}