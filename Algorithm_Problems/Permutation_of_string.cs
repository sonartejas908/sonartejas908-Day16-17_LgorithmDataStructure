using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_and_17Problems
{
    class Permutation_of_string
    {                                  
        private static void permute(String Userstring,int l,int r)
        {
            if (l == r)
                Console.WriteLine(Userstring);
            else
            {               
                for (int i = l;i <= r;i++)
                {
                    Userstring = swap(Userstring, l, i);
                    permute(Userstring, l + 1, r);
                    Userstring = swap(Userstring, l, i);
                }
            }
        }

        public static String swap(String a,int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        public static void StringPermutation()
        {
            String Userstring;
            Console.Write("Please enter string for permutation :");
            Userstring = Console.ReadLine();
            permute(Userstring, 0 ,Userstring.Length -1);
        }
    }

}
