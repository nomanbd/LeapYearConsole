using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsLeapYear(int year)
        {
            bool b = false;
            if (year <= 0)
                throw new ArgumentException("Year can not be < 0");


            if (year % 4 == 0)
            {
                b = true;

                if (year % 400 != 0 && year % 100 == 0)
                {
                    b = false;
                }
                else if (year % 400 == 0 && year % 100 == 0)
                    b = true;
                 

            }
            else
            {
                b = false;
            }
               

            
          
            return b;
        }
    }
}
