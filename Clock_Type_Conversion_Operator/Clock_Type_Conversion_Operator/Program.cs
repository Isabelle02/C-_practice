using System;

namespace Clock_Type_Conversion_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock() { Hours = 15 };
            int val = (int)clock;
            Console.WriteLine(val);
            clock = 13;
            Console.WriteLine(clock.Hours);
        }
    }

    class Clock
    {
        public int Hours { get; set; }

        public static implicit operator Clock(int val)
        {
            return new Clock { Hours = val % 24 };
        }

        public static explicit operator int(Clock clock)
        {
            return clock.Hours;
        }
    }
}
