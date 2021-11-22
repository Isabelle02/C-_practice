using System;

namespace Mas_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Mas<int> mas = new Mas<int>();
            for (int i = 1; i < 5; i++)
            {
                mas.Add(i);
                Console.Write(mas.GetItem(i-1));
            }
            mas.Remove(9);
            mas.Remove(3);
            Console.WriteLine();
            for (int i = 0; i < mas.Length(); i++)
            {
                Console.Write(mas.GetItem(i));
            }
        }
    }

    class Mas<T>
    {
        public T[] Massive;
        public Mas()
        {
            Massive = new T[0];
        }

        public void Add(T Item)
        {
            T[] newMassive = new T[Massive.Length + 1];
            for (int i = 0; i < Massive.Length; i++)
                newMassive[i] = Massive[i];
            newMassive[Massive.Length] = Item;
            Massive = newMassive;
        }

        public void Remove(T Item)
        {
            int count = 0;
            for (int i = 0; i < Massive.Length; i++)
                if (Massive[i].Equals(Item)) count++;
            if (count > 0)
            {
                T[] newMassive = new T[Massive.Length - 1];
                for (int i = 0, j = 0; i < Massive.Length; i++)
                {
                    if (Massive[i].Equals(Item)) continue;
                    newMassive[j] = Massive[i];
                    j++;
                }
                Massive = newMassive;
            }
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < Massive.Length)
                return Massive[index];
            return default(T);
        }


        public int Length()
        {
            return Massive.Length;
        }
    }
}
