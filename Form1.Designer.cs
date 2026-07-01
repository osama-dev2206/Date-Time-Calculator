namespace DateTime_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageTwo = new System.Windows.Forms.TabPage();
            this.btnGetDetailsPag2 = new System.Windows.Forms.Button();
            this.LabDiffInYears = new System.Windows.Forms.Label();
            this.LabDiffInMonths = new System.Windows.Forms.Label();
            this.labDiffInDays = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.btnGetBirthDetails = new System.Windows.Forms.Button();
            this.labSec = new System.Windows.Forms.Label();
            this.labMin = new System.Windows.Forms.Label();
            this.labHours = new System.Windows.Forms.Label();
            this.labMonths = new System.Windows.Forms.Label();
            this.labDays = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tabPageOne = new System.Windows.Forms.TabControl();
            this.tabPageTwo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(570, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Diff Between 2 Times";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPageTwo
            // 
            this.tabPageTwo.Controls.Add(this.btnGetDetailsPag2);
            this.tabPageTwo.Controls.Add(this.LabDiffInYears);
            this.tabPageTwo.Controls.Add(this.LabDiffInMonths);
            this.tabPageTwo.Controls.Add(this.labDiffInDays);
            this.tabPageTwo.Controls.Add(this.label12);
            this.tabPageTwo.Controls.Add(this.label11);
            this.tabPageTwo.Controls.Add(this.label10);
            this.tabPageTwo.Controls.Add(this.dateTimePicker2);
            this.tabPageTwo.Controls.Add(this.dateTimePicker1);
            this.tabPageTwo.Controls.Add(this.label9);
            this.tabPageTwo.Controls.Add(this.label8);
            this.tabPageTwo.Location = new System.Drawing.Point(4, 26);
            this.tabPageTwo.Name = "tabPageTwo";
            this.tabPageTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTwo.Size = new System.Drawing.Size(570, 434);
            this.tabPageTwo.TabIndex = 1;
            this.tabPageTwo.Text = "Diff Between 2 Dates";
            this.tabPageTwo.UseVisualStyleBackColor = true;
            this.tabPageTwo.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnGetDetailsPag2
            // 
            this.btnGetDetailsPag2.BackColor = System.Drawing.Color.Gray;
            this.btnGetDetailsPag2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGetDetailsPag2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGetDetailsPag2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetDetailsPag2.Location = new System.Drawing.Point(219, 352);
            this.btnGetDetailsPag2.Name = "btnGetDetailsPag2";
            this.btnGetDetailsPag2.Size = new System.Drawing.Size(123, 44);
            this.btnGetDetailsPag2.TabIndex = 12;
            this.btnGetDetailsPag2.Text = "Get Details";
            this.btnGetDetailsPag2.UseVisualStyleBackColor = false;
            this.btnGetDetailsPag2.Click += new System.EventHandler(this.btnGetDetailsPag2_Click);
            // 
            // LabDiffInYears
            // 
            this.LabDiffInYears.AutoSize = true;
            this.LabDiffInYears.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiffInYears.Location = new System.Drawing.Point(340, 276);
            this.LabDiffInYears.Name = "LabDiffInYears";
            this.LabDiffInYears.Size = new System.Drawing.Size(24, 28);
            this.LabDiffInYears.TabIndex = 11;
            this.LabDiffInYears.Text = "0";
            // 
            // LabDiffInMonths
            // 
            this.LabDiffInMonths.AutoSize = true;
            this.LabDiffInMonths.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiffInMonths.Location = new System.Drawing.Point(340, 236);
            this.LabDiffInMonths.Name = "LabDiffInMonths";
            this.LabDiffInMonths.Size = new System.Drawing.Size(24, 28);
            this.LabDiffInMonths.TabIndex = 10;
            this.LabDiffInMonths.Text = "0";
            // 
            // labDiffInDays
            // 
            this.labDiffInDays.AutoSize = true;
            this.labDiffInDays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiffInDays.Location = new System.Drawing.Point(340, 188);
            this.labDiffInDays.Name = "labDiffInDays";
            this.labDiffInDays.Size = new System.Drawing.Size(24, 28);
            this.labDiffInDays.TabIndex = 9;
            this.labDiffInDays.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(307, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "The Diff Between 2 Dates In Years Is: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(327, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "The Diff Between 2 Dates In Months Is: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(305, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "The Diff Between 2 Dates In Days Is: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(296, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(235, 25);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Tag = "D2";
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 25);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Tag = "D1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 38);
            this.label9.TabIndex = 3;
            this.label9.Text = "Date2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 38);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.labYear);
            this.tabPage1.Controls.Add(this.btnGetBirthDetails);
            this.tabPage1.Controls.Add(this.labSec);
            this.tabPage1.Controls.Add(this.labMin);
            this.tabPage1.Controls.Add(this.labHours);
            this.tabPage1.Controls.Add(this.labMonths);
            this.tabPage1.Controls.Add(this.labDays);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Age Calc";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(263, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "M - D - Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Your Age In Years : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your Age In Secs : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Your Age In Mins : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Your Age In Hours :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Your Age In Months : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Your Age In Days : ";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYear.Location = new System.Drawing.Point(213, 96);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(0, 23);
            this.labYear.TabIndex = 8;
            // 
            // btnGetBirthDetails
            // 
            this.btnGetBirthDetails.BackColor = System.Drawing.Color.Gray;
            this.btnGetBirthDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGetBirthDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGetBirthDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBirthDetails.Location = new System.Drawing.Point(201, 342);
            this.btnGetBirthDetails.Name = "btnGetBirthDetails";
            this.btnGetBirthDetails.Size = new System.Drawing.Size(123, 44);
            this.btnGetBirthDetails.TabIndex = 7;
            this.btnGetBirthDetails.Text = "Get Details";
            this.btnGetBirthDetails.UseVisualStyleBackColor = false;
            this.btnGetBirthDetails.Click += new System.EventHandler(this.btnGetBirthDetails_Click);
            // 
            // labSec
            // 
            this.labSec.AutoSize = true;
            this.labSec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSec.Location = new System.Drawing.Point(213, 280);
            this.labSec.Name = "labSec";
            this.labSec.Size = new System.Drawing.Size(0, 23);
            this.labSec.TabIndex = 6;
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMin.Location = new System.Drawing.Point(213, 244);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(0, 23);
            this.labMin.TabIndex = 5;
            // 
            // labHours
            // 
            this.labHours.AutoSize = true;
            this.labHours.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHours.Location = new System.Drawing.Point(213, 205);
            this.labHours.Name = "labHours";
            this.labHours.Size = new System.Drawing.Size(0, 23);
            this.labHours.TabIndex = 4;
            // 
            // labMonths
            // 
            this.labMonths.AutoSize = true;
            this.labMonths.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonths.Location = new System.Drawing.Point(213, 166);
            this.labMonths.Name = "labMonths";
            this.labMonths.Size = new System.Drawing.Size(0, 23);
            this.labMonths.TabIndex = 3;
            // 
            // labDays
            // 
            this.labDays.AutoSize = true;
            this.labDays.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDays.Location = new System.Drawing.Point(213, 128);
            this.labDays.Name = "labDays";
            this.labDays.Size = new System.Drawing.Size(0, 23);
            this.labDays.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your Age:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(263, 35);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(122, 30);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // tabPageOne
            // 
            this.tabPageOne.Controls.Add(this.tabPage1);
            this.tabPageOne.Controls.Add(this.tabPageTwo);
            this.tabPageOne.Controls.Add(this.tabPage3);
            this.tabPageOne.Location = new System.Drawing.Point(2, 12);
            this.tabPageOne.Multiline = true;
            this.tabPageOne.Name = "tabPageOne";
            this.tabPageOne.SelectedIndex = 0;
            this.tabPageOne.Size = new System.Drawing.Size(578, 464);
            this.tabPageOne.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetBirthDetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 478);
            this.Controls.Add(this.tabPageOne);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTime Calculator";
            this.tabPageTwo.ResumeLayout(false);
            this.tabPageTwo.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageOne.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageTwo;
        private System.Windows.Forms.Button btnGetDetailsPag2;
        private System.Windows.Forms.Label LabDiffInYears;
        private System.Windows.Forms.Label LabDiffInMonths;
        private System.Windows.Forms.Label labDiffInDays;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Button btnGetBirthDetails;
        private System.Windows.Forms.Label labSec;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label labHours;
        private System.Windows.Forms.Label labMonths;
        private System.Windows.Forms.Label labDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TabControl tabPageOne;
        private System.Windows.Forms.Label label13;
    }
}

