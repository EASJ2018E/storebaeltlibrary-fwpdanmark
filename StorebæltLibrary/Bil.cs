using System;
using BilletLibrary;

namespace StorebæltLibrary
{
    public class Bil : Køretøj
    {
        public override decimal Pris(bool brobizz)
        {
            decimal sum = 0m;
            if (IsWeekend(DateTime.Now) || IsWeekend(this.Dato))
            {
                sum = (240m / 100m) * 80m;
            }
            else
            {
                sum = 240m;
            }

            if (brobizz)
            {
                sum = (sum / 100m)*95m;
            }

            return sum;
        }

        public override string Køretøjet()
        {
            return "Bil";
        }

        public bool IsWeekend(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            return false;
        }
    }

}
