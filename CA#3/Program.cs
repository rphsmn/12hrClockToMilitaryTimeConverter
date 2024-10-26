using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time, day;
            int hour, minute, second;

            Console.WriteLine("Enter a timeslot following 12 hour (AM/PM) format (e.g., 07:05:45 PM): ");
            time = Console.ReadLine();


            // Day (AM/PM) and time 
            day = time.Substring(9,2);

            hour = int.Parse(time.Substring(0,2));

            minute = int.Parse(time.Substring(3, 2));

            second = int.Parse(time.Substring(6, 2));

            // Convert 12-hour time to 24-hour time
            if (day == "AM"|| day == "am")
            {
                if (hour == 12) { hour = 0; }

            }
            else if (day == "PM" || day == "pm")
            {
                if (hour != 12) { hour += 12; }

            }


            if (minute >60) { minute = 59; }

            if (second >60) { second = 59; }


            // Output in 24-hour time
            string hourString = (hour < 10 ? "0" : "") + hour;
            string minuteString = (minute < 10 ? "0" : "") + minute;
            string secondString = (second < 10 ? "0" : "") + second;

            string militarytime = hourString + ":" + minuteString + ":" + secondString;

            Console.WriteLine("The 24 hour/military time format is: " + militarytime);
        }   
    }
}
