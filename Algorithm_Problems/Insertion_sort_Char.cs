using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_and_17Problems
{
    class Insertion_sort_Char
    {
        public static char[] CharArray = { 'E', 'B', 'N', 'L', 'K', 'F', 'S' };

        public static int n = CharArray.Length; 
        public static void sort()
        {
            Console.WriteLine("Characters before sort :");
            foreach (var element in CharArray)
            {
                Console.Write(element + " ");
            }
            for (int i = 0; i < n; i++) //0-6
            {
                for (int j =i+1; j < n; j++)//1-6
                {
                    if(CharArray[i] > CharArray[j])  // E > B
                    {
                        char temp = CharArray[i];  //temp = E
                       CharArray[i] = CharArray[j];//E is replaced by B
                        CharArray[j] = temp; // B is replaced by E
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Characters after sort :");
            foreach(var element in CharArray)
            {
                Console.Write(element + " ");
            }
        }
            
    }
}
