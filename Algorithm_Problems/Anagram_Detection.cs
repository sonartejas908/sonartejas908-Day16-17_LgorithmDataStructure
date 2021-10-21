using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_and_17Problems
{
    class Anagram_Detection
    {
       public static void DetectAnagram()
        {
            Console.WriteLine("Welcome to anagram Detection\n");
            Console.Write("Enter First Word :");
            string word1 = Console.ReadLine(); 
            char[] char1 = word1.ToCharArray();
            Console.Write("Enter Second Word :");
            string word2 = Console.ReadLine();
            char[] char2 = word2.ToCharArray();

            sort(char1);
            sort(char2);

            Console.Write("Sorted First Word is : ");
            Console.WriteLine(char1);
            Console.Write("Sorted Second Word is : ");
            Console.WriteLine(char2);
            string sorted1 = char1.ToString();
            string sorted2 = char2.ToString();

            if (sorted1 == sorted2)
            {
                Console.WriteLine("\nConclusion : Words are Anagram");
            }
            else
            Console.WriteLine("\nConclusion : Words are not Anagram");
            
            
            
        }

        static void sort(char[] Input)
        {
            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = i + 1; j < Input.Length; j++)
                {
                    if (Input[i] > Input[j]) //(5,2,1)
                    {
                        char temp = Input[i];
                        Input[i] = Input[j];
                        Input[j] = temp;
                    }
                }
            }


        }
    }
}
