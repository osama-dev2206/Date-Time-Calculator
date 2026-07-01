using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Calculator
{
             // presentation logic for tab 3  /// 
    public partial class frmAllTabPages : Form
    {
        DateTime dTime1 = DateTime.Now;
        DateTime dTime2= DateTime.Now; 

        void RestTabPage3Labels()
        {
            this.labDiffBetweenTimesHour.Text = "0";
            this.labDiffBetweenTimesMin.Text = "0";
            this.labDiffBetweenTimesSecs.Text = "0";
        }

        void UpdateTabPage3Labels()
        {
            clsDateTimeCore.stTime Diff = clsDateTimeCore.GetDiffBetweenTime1AndTime2(dTime1, dTime2);
        
            this.labDiffBetweenTimesHour.Text =Diff.hour.ToString();
            this.labDiffBetweenTimesMin.Text = Diff.minute.ToString();
            this.labDiffBetweenTimesSecs.Text =Diff.second.ToString();
        }

         void ShowTimeErrorMessage()
        {
            MessageBox.Show("Time 1 Should not Be Smaller Than Time2 ", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dTime1 = this.dtpTime1.Value;
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dTime2=  this.dtpTime2.Value; 
        }

        private void btnStartCalcDiffInTimes_Click(object sender, EventArgs e)
        {
            if (!clsDateTimeCore.CheckIfTime1IsBiggerThanTime2(dTime1, dTime2))
            {
                ShowTimeErrorMessage();

            }
            else  UpdateTabPage3Labels();
        }

    }
}
