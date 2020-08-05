using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step195
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is current day of the week?\n");
            string CurrentDay = Convert.ToString(Console.ReadLine()).ToLower();

            try
            {
                daysOfTheWeek day = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), CurrentDay);
                Console.WriteLine("\nToday is " + char.ToUpper(CurrentDay[0]) + CurrentDay.Substring(1));
            }
            catch (Exception e)
            {
                Console.WriteLine("\nPlease enter an actual day of the week.");
            }
            Console.ReadLine();
        }
        enum daysOfTheWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
