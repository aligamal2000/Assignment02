using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment02
{
    #region  Part 3 Q2-Develop a Class to represent the Hiring Date Data:consisting of fields to hold the day, month and Years.

    internal class HireDate
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }

        public HireDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
                throw new ArgumentException("Invalid day.");
            if (month < 1 || month > 12)
                throw new ArgumentException("Invalid month.");
            if (year < 2000 || year > DateTime.Now.Year)
                throw new ArgumentException("Invalid year.");

            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString() => $"{Day:D2}/{Month:D2}/{Year}"; 
        #endregion

    }
}
