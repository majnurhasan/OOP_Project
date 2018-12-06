using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNine
{
    public class Calculations
    {
        public int CalculateAge(string birthDate)
        {
            int ageInMonths;
            int age;

            DateTime dateToday = DateTime.UtcNow;
            DateTime past = Convert.ToDateTime(birthDate);

            ageInMonths = 12 * (dateToday.Year - past.Year) + (dateToday.Month - past.Month);
            age = ageInMonths / 12;

            return age;
        }

        public double CalculateInterest(double principalAmount, double monthlyRate)
        {
            return principalAmount * (monthlyRate / 100);
        }

        public double CalculateAccruedAmount(string endDate, double principalAmount, double monthlyRate)
        {
            int numberOfMonths;

            DateTime dateToday = DateTime.UtcNow;
            DateTime future = Convert.ToDateTime(endDate);

            numberOfMonths = 12 * (future.Year - dateToday.Year) + (future.Month - dateToday.Month);

            double i = CalculateInterest(principalAmount, monthlyRate);

            return principalAmount + (i * numberOfMonths);
        }

        public static double GetSalary(bool fullTime, double rate, Enum taxpayer)
        {
            //Access excel file somewhere from here to have reference in calculating the Salary
            //Lots of different salary because it depends if you're full time or not, kinds of taxpayer and everything
            if (fullTime)
            {
                //rate is fixed
            }
            else
            {
                //rate is in hours
            }
            return 0;
        }

    }
}
