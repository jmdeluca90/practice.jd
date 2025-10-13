using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class DayOfTheProgrammer
    {
        // my first run through - can definitely be simplified and consolidated
        // ex: 1918 will always be the same date - 26.09.1918; if its a leap year the total days = 244, if not total days = 243
        public static string dayOfProgrammer(int year)
        {
            // day of the programmer = 256th day of the year

            string result = "";
            if (year < 1918) { result = CalculateJulian(year, IsLeapYear(year)); }
            if (year > 1918) { result = CalculateGregorian(year, IsLeapYear(year)); }
            if (year == 1918) { result = StupidAssMothafuckinYear(year); }


            return result;
        }
        public static string StupidAssMothafuckinYear(int year)
        {
            string result = "";
            int[] months = new int[8];
            for (int i = 0; i < months.Length; i++)
            {
                if (i % 2 == 0) { months[i] = 31; }
                if (i == 1) { months[i] = 15; continue; }
                if (i == 7) { months[i] = 31; continue; }
                else if (i % 2 == 1)
                {
                    months[i] = 30;
                }
            }
            int sum = months.Aggregate((x, y) => (x + y));
            int day = 256 - sum;
            result = day.ToString() + ".09." + year.ToString();

            return result;
        }
        public static string CalculateJulian(int year, bool isLeapYear)
        {
            string result = "";
            int[] months = new int[8];

            for (int i = 0; i < months.Length; i++)
            {
                if (i % 2 == 0) { months[i] = 31; }
                if (i == 1) { months[i] = 28; continue; }
                if (i == 7) { months[i] = 31; continue; }
                else if (i % 2 == 1)
                {
                    months[i] = 30;
                }
            }
            if (isLeapYear) { months[1]++; }
            int sum = months.Aggregate((x, y) => (x + y));
            int day = 256 - sum;
            result = day.ToString() + ".09." + year.ToString();
            return result;
        }
        public static string CalculateGregorian(int year, bool isLeapYear)
        {
            string result = "";
            int[] months = new int[8];

            for (int i = 0; i < months.Length; i++)
            {
                if (i % 2 == 0) { months[i] = 31; }
                if (i == 1) { months[i] = 28; continue; }
                if (i == 7) { months[i] = 31; continue; }
                else if (i % 2 == 1)
                {
                    months[i] = 30;
                }
            }
            if (isLeapYear) { months[1]++; }

            int sum = months.Aggregate((x, y) => x + y);
            int day = 256 - sum;

            result = day.ToString() + ".09." + year.ToString();
            return result;
        }
        public static bool IsLeapYear(int year)
        {
            bool isLeapYear = false;
            if (year > 1918)
            {
                isLeapYear = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ? true : false;
            }
            if (year < 1918)
            {
                isLeapYear = year % 4 == 0 ? true : false;
            }
            return isLeapYear;
        }
        // here is a version of it that is a bit more simplified, but we could simplify even more and not have to use IsLeapYear method
        public static string DayOfTheProgrammerSimplified(int year)
        {
            string result = string.Empty; // or string result = "";
            if (year == 1918) { result = "26.09.1918"; }

            if (IsLeapYear(year)) { result = "12.09." + year.ToString(); }

            if (!IsLeapYear(year)) { result = "13.09." + year.ToString(); }

            return result;
        }
        public static string DayOfTheProgrammerBestSolutionYet(int year) 
        {
            if (year == 1918)
                return "26.09.1918";
            bool isLeapYear;
            if (year < 1918)
                isLeapYear = (year % 4 == 0);
            else
                isLeapYear = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);

            int day = isLeapYear ? 12 : 13;
            return day.ToString("D2") + ".09." + year.ToString();
        }
    }
}
