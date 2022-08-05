using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    /// <summary>
    /// ClsAge prend en charge la notion d'age entre 2 dates
    /// </summary>
    public static class ClsAge
    {
        static readonly int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static readonly int[] daysInMonthLeap = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        /// <summary>
        /// GetAge calcule l'age en année, mois, jours.
        /// </summary>
        /// <param name="pBeginDate">doit être une date YYYY-MM-DD</param>
        /// <param name="pEndDate">doit être une date YYYY-MM-DD</param>
        /// <returns> un tableau de 3 cellules avec année dans la première cellule ...</returns>
        public static int[] GetAge(DateTime pBeginDate, DateTime pEndDate)
        {
            // Test de garde (programmation défensive)
            if (pBeginDate > pEndDate) throw new ArgumentException("Date début > date fin");
            // fin des tests de garde


            DateTime endDate = pEndDate.Date;
            DateTime beginDate = pBeginDate.Date;

            int ageYear = CalculateYears(endDate, beginDate);
            int ageMonth = CalculateMonths(endDate, beginDate);
            int ageDays = CalculateDays(endDate, beginDate);

            int[] age = { ageYear, ageMonth, ageDays };
            // Tests de sortie (age < 0 )
            if (age == null) throw new ArgumentException("Date début > date fin");
            return age;

        }

        private static int CalculateDays(DateTime endDate, DateTime beginDate)
        {
            int ageDays = endDate.Day - beginDate.Day;
            if (ageDays < 0)
            {

                // -2 because -1 to fit the array index and another -1 because we start from previous month to count days
                int monthIndex = endDate.Month - 2;
                monthIndex = monthIndex < 0 ? monthIndex + 12 : monthIndex;
                ageDays += DateTime.IsLeapYear(endDate.Year) ? daysInMonthLeap[monthIndex] : daysInMonth[monthIndex];
            }

            return ageDays;
        }

        private static int CalculateMonths(DateTime endDate, DateTime beginDate)
        {
            int ageMonth = endDate.Month - beginDate.Month;
            if (ageMonth < 0) ageMonth += 11;
            else if (ageMonth == 0 && (endDate.Day - beginDate.Day) < 0) ageMonth += 11;
            else if((endDate.Day - beginDate.Day) < 0)
            {
                ageMonth--;
            }

            return ageMonth;
        }

        private static int CalculateYears(DateTime endDate, DateTime beginDate)
        {
            int ageYear = endDate.Year - beginDate.Year;
            DateTime virtualDateYear = endDate.AddYears(-ageYear);
            if (beginDate > virtualDateYear) ageYear--;
            return ageYear;
        }

        public static int[] GetAge(DateTime dateTime)
        {
            return GetAge(dateTime, DateTime.Today);
        }
    }
}
