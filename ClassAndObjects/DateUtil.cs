using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ClassAndObjects
//{ 
    internal static class DateUtil
    {
    public static object Console { get; internal set; }

    public static int YearofBirth(int age)
        {
            
            return DateTime.Now.Year - age;
        }

        public static int YearofBirth(DateTime dateofBirth)
        {
            if(dateofBirth==null)
            {
                return 0;
            }
            return dateofBirth.Year;
        }

        public static int Age (DateTime dateofBirth)
        {

            return DateTime.Now.Year - dateofBirth.Year;
        }
    }
//}
