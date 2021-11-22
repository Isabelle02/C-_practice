using System;

namespace Mas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan; // устанавливаем цвет
            //Console.ResetColor();
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                            { { 4, 5 }, { 6, 7 } },
                            { { 7, 8 }, { 9, 10 } },
                            { { 10, 11 }, { 12, 13 } }
                          };

            int length = mas.GetUpperBound(2) + 1;
            int height = mas.GetUpperBound(1) + 1;
            int width = mas.GetUpperBound(0) + 1;

            Console.Write("{");
            for (int i = 0; i < width; i++)
            {
                Console.Write("{");
                for (int j = 0; j < height; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < length; k++)
                    {
                        Console.Write($"{mas[i, j, k]}");
                        if (k < length - 1) Console.Write(",");
                    }
                    Console.Write("}");
                    if (j < height - 1) Console.Write(",");
                }
                Console.Write("}");
                if (i < width - 1) Console.Write(",");
            }
            Console.Write("}");
        }
    }
}
