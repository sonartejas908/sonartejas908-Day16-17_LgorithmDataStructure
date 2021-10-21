using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problems
{
    public class Primt_Range
    {

        public static int flag;
        public static void PrimeRange()
        {
            for (int j = 2; j <=100 ; j++)
            {
                primeCheck(j);
            }
        }
        public static void primeCheck(int Num1)
        {
            for (int i = 2; i <= Num1/2; i++)
            {
                if(Num1%i == 0)
                {
                   flag = 1;
                }   
                
            }
            if(flag == 0)
            {
                Console.WriteLine("{0} is Prime Number",Num1);
            }
            else
            {
                Console.WriteLine("{0} is Not a Prime Number",Num1);
            }
           
        }

    }
}
