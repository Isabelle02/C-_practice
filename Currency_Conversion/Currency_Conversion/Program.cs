using System;

namespace Currency_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro euro = new Euro { Sum = 15 };
            Dollar dollar = (Dollar)euro;
            Console.WriteLine("15e is {0}$", dollar.Sum);
            euro = dollar;
            Console.WriteLine("{0}$ is {1}e", dollar.Sum, euro.Sum);
        }
    }

    class Dollar
    {
        public decimal Sum { get; set; }
    }

    class Euro
    {
        public decimal Sum { get; set; }

        public static explicit operator Dollar(Euro euro)
        {
            return new Dollar { Sum = euro.Sum * 1.14M};
        }

        public static implicit operator Euro(Dollar dollar)
        {
            return new Euro { Sum = dollar.Sum / 1.14M };
        }
    }
}
