using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRial1
{
    /* public class Date
     {

         private int month = Console.Read();

         public int Month
         {
             get
             {
                 return month;
             }
             set
             {
                 if (value > 0 && value < 13)
                 {
                     month = value;

                 }
                 else
                 {
                     Console.WriteLine("Try write month properly");

                 }

             }
         }
     }*/
     class Calendar
    {
         public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,Sunday};

         public enum Month : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Calendar.Day today = (Calendar.Day)5;
            Console.WriteLine("{0} is day number #{1}", today, (int)today + 1);
            ConsoleKeyInfo keyinfo;
            do
            {
                Console.WriteLine("Press Spacebar to view month...");
                keyinfo = Console.ReadKey(true);
                Console.Clear();
            }
            while (keyinfo.Key != ConsoleKey.Spacebar);

            Calendar.Month thismonth = Calendar.Month.Aug;
            Console.WriteLine("{0} is month #{1}",thismonth,(int)thismonth+1);
            do
            {
                Console.WriteLine("Press Spacebar to quit...");
                keyinfo = Console.ReadKey(true);
            }
            while (keyinfo.Key != ConsoleKey.Spacebar);
        }

}
}
