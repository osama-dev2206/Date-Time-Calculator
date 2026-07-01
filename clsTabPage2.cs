using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Calculator
{
    // Tab page 2 prsentation logic ///  
    public partial class frmAllTabPages : Form
    {

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Focus();
        }

        DateTime Date1;
        DateTime Date2;
        bool IsValidOpeartion = true; 

        void DisplayDate1IsBiggerThan2Error()
        {
            MessageBox.Show("Date 1 should be smaller than date 2 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!clsDateTimeCore.CheckDate(clsDateTimeCore.ExtractDateFromDateTimePicker(sender as DateTimePicker), out _))
            {
                MessageBox.Show("Date Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Date2= DateTime.Now; // intilize date 2 
                
                clsDateTimeCore.UpdateDate(sender as DateTimePicker, ref Date1, ref Date2); // update at first 

                if (!clsDateTimeCore.CheckDate(Date1, Date2)) // if d1> d2  ==> then check the date 
                {
                    DisplayDate1IsBiggerThan2Error();
                    IsValidOpeartion = false;
                }
                else
                {
                    IsValidOpeartion = true;
                }

            } 
        }


        void UpdateLabels()
        {
            TimeSpan DiffBetween2Dates = clsDateTimeCore.GetDiffBetweenDate1AndDate2(Date1, Date2);
            this.labDiffInDays.Text = Math.Abs (DiffBetween2Dates.Days).ToString();
            this.LabDiffInMonths.Text = clsTimeSpanUtils.GetNumOfMonthsFromDays(days: Math.Abs(DiffBetween2Dates.Days), Date1).ToString();
            this.LabDiffInYears.Text = clsTimeSpanUtils.GetNumOfYearsFromDays(days:  Math.Abs(DiffBetween2Dates.Days)).ToString();
        }

        private void btnGetDetailsPag2_Click(object sender, EventArgs e)
        {
            if (!IsValidOpeartion) DisplayDate1IsBiggerThan2Error();
            else UpdateLabels();
        }


    }

}
