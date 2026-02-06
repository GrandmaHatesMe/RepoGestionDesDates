using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // 🔹 Retourne le nombre de jours dans un mois
        public static int DaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(
                    "month",
                    "Le mois fourni n'existe pas !");
            }

            int[] daysPerMonth =
            {
                31, 28, 31, 30,
                31, 30, 31, 31,
                30, 31, 30, 31
            };

            if (month == 2 && IsLeapYear(year))
            {
                return 29;
            }

            return daysPerMonth[month - 1];
        }

        // 🔹 Valide une date complète
        public static void ValidateDate(int day, int month, int year)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(
                    "month",
                    "Le mois fourni n'existe pas !");
            }

            int maxDays = DaysInMonth(month, year);

            if (day < 1 || day > maxDays)
            {
                throw new ArgumentOutOfRangeException(
                    "day",
                    "Le jour fourni n'existe pas !");
            }
        }

        // 🔹 Numéro du jour dans l'année
        public static int DayOfYear(int month, int dayOfMonth, int year)
        {
            ValidateDate(dayOfMonth, month, year);

            int dayNumber = 0;

            for (int i = 1; i < month; i++)
            {
                dayNumber += DaysInMonth(i, year);
            }

            dayNumber += dayOfMonth;

            return dayNumber;
        }
    }
}
