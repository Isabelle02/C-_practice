using System;

namespace SortMas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[7];
            Console.WriteLine("Input 7 numbers");
            for (int i = 0; i < nums.Length; i++)
            {
                //nums[i] = Int32.Parse(Console.ReadLine());
                nums[i] = Convert.ToInt32((Console.ReadLine()));
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            Console.WriteLine("Output of 7 sorted numbers");
            foreach (int i in nums)
                Console.Write($"{i} ");
        }
    }
}
