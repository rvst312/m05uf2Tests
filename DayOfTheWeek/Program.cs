using System;

namespace DayOfTheWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a day");
            int day = int.Parse(Console.ReadLine());
            int dayofweek = DayOfTheWeek(year, month, day);
            Console.WriteLine("The day of the week is:");
            switch (dayofweek)
            {
                case 0: Console.WriteLine("Saturday"); break;
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                default: Console.WriteLine("Unknown"); break;
            }
        }
        public static int DayOfTheWeek(int year, int month, int day)
        {
            if (month < 3)
            {
                month += 12;
                year -= 1;
            }
            int k = year % 100;
            int j = year / 100;
            int h = (day + 13 * (month + 1) / 5 + k + k / 4 + j / 4 + 5 * j) % 7;
            return h;
        }
    }
}
