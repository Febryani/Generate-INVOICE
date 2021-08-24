using System;
using RomanNumerals;
using System.Globalization;

namespace Generate_Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1098;
            Console.WriteLine(GenerateCode(counter));
        }

        static string GenerateCode(int counter)
        {
            string month, year, day;
            int date;
            CultureInfo inEng = new CultureInfo("en-GB");
            var today = DateTime.Today;
            year = today.ToString("yyyy");
            month = today.ToString("MM");
            date = (int)today.Day;
            day = today.ToString("ddd", inEng).Substring(0, 2).ToUpper();
            var roDate = new RomanNumerals.RomanNumeral(date);
            var roYear = new RomanNumerals.RomanNumeral(Convert.ToInt32(today.ToString("yy")));
            return ($"INV/{year}{month}/{day}/{roDate}/{roYear}/{counter++}");
        }


    }
}
