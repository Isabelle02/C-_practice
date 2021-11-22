using System;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Arge.NbYear(1500000, 0.25, 1000, 2000000);
            Console.WriteLine(year);
        }
    }

    class Arge
    {

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            // your code
            int year = 0;
            //double x;
            while (p0 < p)
            {
                // x = Convert.ToDouble(p0);
                p0 = Convert.ToInt32(Math.Floor(p0 + (double)p0 * percent / 100.0 + aug));
                //p0 = Convert.ToInt32(x);
                year++;
            }
            return year;
        }
    }
}
