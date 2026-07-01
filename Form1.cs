using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DateTime_Calculator
{
                                             // Tab page 1 persentation logic ///  
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime UserEnteredDateTime;// provided by user (date of birth)  M - D - Y 
        TimeSpan AgeBirthDetails; // provided by clsDateTimeCore ==> to get the diff details from start date of birth untill now 

        void UpdateAgeLabels()
        {
            this.labHours.Text = " " + clsTimeSpanUtils.GetHoursFromDays(days:   Math.Abs(AgeBirthDetails.Days ) ).ToString();
            this.labMin.Text = " " + clsTimeSpanUtils.GetMinsFromDays(days: Math.Abs(AgeBirthDetails.Days)).ToString();
            this.labSec.Text = " " + clsTimeSpanUtils.GetSecsFromDays(days: Math.Abs(AgeBirthDetails.Days)  ).ToString();
            this.labDays.Text=" "+AgeBirthDetails.Days.ToString();

            // y / m /d 

            this.labMonths.Text = " " + clsTimeSpanUtils.GetNumOfMonthsFromDays(days:Math.Abs (AgeBirthDetails.Days), StartYear: this.UserEnteredDateTime).ToString();
            this.labYear.Text = " " +clsTimeSpanUtils.GetNumOfYearsFromDays(days:Math.Abs(AgeBirthDetails.Days), StartYear:this.UserEnteredDateTime).ToString(); 

        }

        void RestUserEnteredDateTime()
        {
            UserEnteredDateTime =  DateTime.Now;
            RestLabel();
        }

        void RestLabel()
        {
            this.labHours.Text = " " ;
            this.labMin.Text = " ";
            this.labSec.Text = " " ;
            this.labDays.Text = " " ;
            this.labMonths.Text= " " ;
            this.labYear.Text= " " ;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            // if user filled text box but the date isn't valid 
            if(maskedTextBox1.MaskCompleted && !( clsDateTimeCore.CheckDate(maskedTextBox1.Text, out UserEnteredDateTime) )   )
            {
                MessageBox.Show("Wrong Date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

        private void btnGetBirthDetails_Click(object sender, EventArgs e)
        {
            if( !clsDateTimeCore.IsValidBirthDate(UserEnteredDateTime)  ||  !maskedTextBox1.MaskFull )  /// check the birth date validation 
            {
                MessageBox.Show("Empty Date Or Wrong Date !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                RestUserEnteredDateTime();
            }
            else
            {
                AgeBirthDetails = clsDateTimeCore.GetDiffBetweenNowDateAndCurrentDate(this.UserEnteredDateTime); // get the dif 
                UpdateAgeLabels();
            }

        }

        private void tabPage1_Click(object sender, EventArgs e) // when you click on the page 1
        {
            this.maskedTextBox1.Focus(); 
        }

    }

}
