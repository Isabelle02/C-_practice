using System;
using System.Linq;

namespace valid_parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (Parentheses.ValidParentheses(str)) Console.WriteLine("Success");
            else Console.WriteLine("Fail");
        }
    }

    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            input = string.Concat(input.Where(x => "()".Contains(x)));
            while (input.Contains("()"))
            {
                input = input.Replace("()", "");
            }

            return !input.Any();
        }
    }
}
