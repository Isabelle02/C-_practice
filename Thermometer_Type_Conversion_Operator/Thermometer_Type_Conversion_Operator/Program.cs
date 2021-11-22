using System;

namespace Thermometer_Type_Conversion_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius Tc = new Celcius { Degree = 25 };
            Fahrenheit Tf = (Fahrenheit)Tc;
            Console.WriteLine($"25C is {Tf.Degree}F");
            Tc = (Celcius)Tf;
            Console.WriteLine($"{Tf.Degree}F is {Tc.Degree}C");
        }
    }

    class Celcius
    {
        public double Degree { get; set; }
    }

    class Fahrenheit
    {
        public double Degree { get; set; }
        public static explicit operator Celcius(Fahrenheit Tf)
        {
            return new Celcius { Degree = 5.0 / 9.0 * (Tf.Degree - 32.0) };
        }
        public static explicit operator Fahrenheit(Celcius Tc)
        {
            return new Fahrenheit { Degree = 9.0 / 5.0 * Tc.Degree + 32.0 };
        }
    }


}
