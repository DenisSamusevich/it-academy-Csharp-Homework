using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HW05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex_correct_format_date = new Regex(@"\d{4}\.\d{2}");
            Regex regex_year_birth = new Regex(@"^\d{4}");
            Regex regex_month_birth = new Regex(@"\d{2}$");
            Match match_year_birth;
            Match match_month_birth;
            string data_birth;
            string year_birth;
            string month_birth;
            int num_years;
            int num_month;
            int full_years;
            var today = DateTime.Today;
            Console.WriteLine("Input the year and month of birth in the format yyyy.mm");
            while (true)
            {
                data_birth = Console.ReadLine();
                if (data_birth.Length == 7 && regex_correct_format_date.IsMatch(data_birth))
                {
                    match_year_birth = regex_year_birth.Match(data_birth);
                    match_month_birth = regex_month_birth.Match(data_birth);
                    year_birth = match_year_birth.Value;
                    month_birth = match_month_birth.Value;
                    num_years = Convert.ToInt32(year_birth);
                    num_month = Convert.ToInt32(month_birth);
                    if (num_month <= 12 && num_years <= today.Year)
                        if (!(num_years == today.Year && num_month <= today.Month))
                            break;
                }
                Console.WriteLine("Incorrect format, try again");
            }
            full_years = today.Year +(Convert.ToInt32(month_birth) >= today.Month ? 0:-1);
            Console.WriteLine("Total years = " + full_years);
            Console.Read();
        }
    }
}
