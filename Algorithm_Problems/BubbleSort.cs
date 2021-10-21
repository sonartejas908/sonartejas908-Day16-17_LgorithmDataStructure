using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_and_17Problems
{
    class BubbleSort
    {
        public static void UserInput()
        {
            Console.WriteLine("Enter the Number of integer :");
            int freq = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= freq; i++)

            {
                Console.WriteLine("Enter number {0} :", i);
                int A = int.Parse(Console.ReadLine());
                list.Add(A);
            }

            int temp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - (1 + i); j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }

            }
            Console.WriteLine("Bubble sorted list is :");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

    }
}

   
