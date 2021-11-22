using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State() { Area = 100, Population = 250 };
            State state2 = new State() { Area = 200, Population = 247 };
            State state3 = state1 + state2;
            Console.WriteLine($"Area: {state3.Area}. Population: {state3.Population}");
            bool isGreater = state1 > state2;
            if (isGreater) Console.WriteLine("state1 more than state2");
            else Console.WriteLine("state2 more than state1");
        }

        class State
        {
            public decimal Population { get; set; } // население
            public decimal Area { get; set; }       // территория

            public static State operator +(State state1, State state2)
            {
                return new State {
                    Area = state1.Area + state2.Area,
                    Population = state1.Population + state2.Population
                };
            }

            public static bool operator >(State state1, State state2)
            {
                return state1.Area > state2.Area;
            }
            public static bool operator <(State state1, State state2)
            {
                return state1.Area < state2.Area;
            }
        }
    }
}
