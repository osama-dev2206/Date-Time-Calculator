using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Calculator
{
    internal static class clsDateTimeCore
    {
    
       static public bool CheckDate(string Date ,out  DateTime  Res )
        {
            return DateTime.TryParse(Date , out Res); // will return true if correct date 
        }

        static public bool IsValidBirthDate(DateTime DateOfBirth) // check if the date of birth is smaller than or equl current date 
        {
            if (DateOfBirth == default(DateTime)) return false; 
            return (DateOfBirth < DateTime.Now) ? true : false; 
        }

        static public TimeSpan GetDiffBetweenNowDateAndCurrentDate(DateTime Date)
        {
            if (IsValidBirthDate(Date)) return (DateTime.Now - Date);
            else return new TimeSpan(0, 0, 0);
        }

        static private void CheckDefaultDate(ref DateTime Date) // if date is default date then set the date to now 
        {
            if(Date == default(DateTime))
                Date = DateTime.Now;
        }

        static public TimeSpan GetDiffBetweenDate1AndDate2(DateTime Date1 ,DateTime Date2)
        {
            
            if (!CheckDate(Date1.Date.ToString() , out _ ) || !CheckDate(Date2.Date.ToString(),out _ ) )  return new TimeSpan(0,0,0);
            else
            {
                CheckDefaultDate(ref Date1); // if date is the default date 
                CheckDefaultDate(ref Date2); // if date is the default date 
                return (Date1) - (Date2);
            }
        }

        static public  string ExtractDateFromDateTimePicker(DateTimePicker dateTimePicker)
        {
            return dateTimePicker.Value.ToString().Remove(dateTimePicker.Value.ToString().IndexOf(" ")).Trim();

        }


        /// <summary>
        /// /  Form Validation  Logic (tab page 2) 
        /// </summary>


   
      internal static   void UpdateDate(DateTimePicker dt , ref DateTime Date1 , ref  DateTime Date2  )
        {
         
            switch (dt.Tag.ToString().ToLower())
            {
                case "d1":
                    clsDateTimeCore.CheckDate(clsDateTimeCore.ExtractDateFromDateTimePicker(dt), out Date1);
                    break;

                case "d2":
                    clsDateTimeCore.CheckDate(clsDateTimeCore.ExtractDateFromDateTimePicker(dt), out Date2);
                    break;

            }
        }

        internal static bool CheckDate(DateTime d1 , DateTime d2)
        {
            return (d1<d2)? true : false;
        }


    }


}
