using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.CM_Days_until_Christmas_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables for current day and this years christmas day
            DateTime today = DateTime.Today;
            DateTime christmasDay = new DateTime(2024, 12, 25);

            // Loop that calculates days left to christmas and prints it
            while (true)
            {
                if (today < christmasDay)
                {
                    TimeSpan untilChristmasDay = christmasDay - today;
                    Console.Write("Days until christmas day: ");
                    string convertChristmasDay = untilChristmasDay.ToString();
                    string trimmedChristmasDay = convertChristmasDay.Remove(convertChristmasDay.Length - 9); // Remove last 9 characters to only show days in clean format
                    Console.WriteLine(trimmedChristmasDay);
                    break;
                }
                else // Add one year to Christmas day in case the date has been passed
                {
                    christmasDay = christmasDay.Date.AddYears(1);
                }
            }
            Console.ReadLine();
        }
    }
}
