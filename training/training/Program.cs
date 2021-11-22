using System;
using System.Collections;

namespace training
{
    class Program
    {
        class Table
        {
            int _columns;
            ArrayList types = new ArrayList();
            ArrayList Field = new ArrayList(); 
            public int Columns
            {
                get => _columns;
                set => _columns = value;
            }

            public void Draw()
            {
                for (int i = 0; i < _columns; i++)
                {
                    Console.Write($"|\t{types[i]}\t\t");
                    if (i == _columns - 1) Console.Write("|\n");
                }
                
                for (int j = 0; j < Field.Count / _columns; j++)
                {
                    for (int i = 0; i < _columns; i++)
                    {
                        Console.Write($"|\t{Field[i+4*j]}\t\t");
                        if (i == _columns - 1) Console.Write("|\n");
                    }
                }
            }

            public void Read()
            {
                for (int i = 0; i < _columns; i++)
                {
                    Console.WriteLine($"{types[i]}: ");
                    Field.Add(Console.ReadLine());
                }
            }

            public void Create()
            {
                Console.WriteLine("Input number of columns: ");
                int.TryParse(Console.ReadLine(), out _columns);
                for (int i = 0; i < _columns; i++)
                {
                    Console.WriteLine($"Field {i + 1}: ");
                    types.Add(Console.ReadLine());
                }
            }

        }

        class Menu
        {
            int _index = -1;
            public int Index {
                get => _index;
                set =>_index = value;
            }
            public void Draw()
            {
                string[] menu = { "Create Table", "Add", "Show Table", "Escape" };
                for (int i = 0; i < 4; i++)
                    Console.WriteLine($"{i} - {menu[i]}");
                while (_index < 0 || _index > 3)
                {
                    int.TryParse(Console.ReadLine(), out _index);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Table table = new Table();
            Menu menu = new Menu();

            while (menu.Index != 3)
            {
                menu.Index = -1;
                menu.Draw();
                switch (menu.Index)
                {
                    case 0:
                        table.Create();
                        break;
                    case 1:
                        table.Read();
                        break;
                    case 2:
                        table.Draw();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
