using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Calculator
{
    internal static partial class clsDateTimeCore
    {
        internal  struct stTime
        {
            public int  hour;
            public int minute;
            public int second;
        }

        private static int ConvertHoursToSeconds(int hour)
        {
            return hour * 360; 
        }

        private static int ConvertHoursToMins(int hour)
        {
            return hour * 60;
        }

        private static stTime ConvertDateTimeToTimeOnly(DateTime dt) // convert dt to stime to get h , m , s only 
        {
            stTime time;
            time.hour = dt.Hour;
            time.minute = ConvertHoursToMins(dt.Hour); // gets exactly diff in mins 
            time.second = ConvertHoursToSeconds(dt.Hour);  // gets exactly diff in secs  


            return time;    
        }


       private   static stTime ConvertTimeSpanToTimeOnly(TimeSpan ts) // get h,m,s from timespan 
        {
            stTime time;
            time.hour = ts.Hours;
            time.minute = ConvertHoursToMins(ts.Hours);
            time.second = ConvertHoursToSeconds( ts.Hours);
           
            return time;
        }


        internal static bool CheckIfTime1IsBiggerThanTime2(DateTime Time1 , DateTime Time2)
        {
          if (ConvertDateTimeToTimeOnly(Time1).hour > ConvertDateTimeToTimeOnly(Time2).hour )
            {
                return true; 
            }
            else if (ConvertDateTimeToTimeOnly(Time1).hour == ConvertDateTimeToTimeOnly(Time2).hour && ConvertDateTimeToTimeOnly(Time1).minute > ConvertDateTimeToTimeOnly(Time2).minute)
            {
                return true;
            }
            else return false; 
        }

        private static TimeSpan GetDiffBetween2Times(DateTime Time1, DateTime Time2)
        {
            return Time1 - Time2;
        }

        // The Method You Want To Call Only In Presentation Logic 
        internal static stTime GetDiffBetweenTime1AndTime2(DateTime Time1 , DateTime Time2)
        {
            if(CheckIfTime1IsBiggerThanTime2(Time1,Time2))
            {
                TimeSpan Diff = GetDiffBetween2Times(Time1, Time2);
                return ConvertTimeSpanToTimeOnly(Diff);
            }
            else return ConvertTimeSpanToTimeOnly(new TimeSpan(0,0,0));
        }
            


    }
   


}

    


