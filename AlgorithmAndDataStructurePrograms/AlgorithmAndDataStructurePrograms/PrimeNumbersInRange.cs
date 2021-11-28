using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructurePrograms
{
    public class PrimeNumbersInRange
    {
        public void PrimeNumbers()
        {

            
            Console.Write("\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n");

            Console.Write("Input starting number of range: ");
            int startingnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            int endingnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", startingnumber, endingnumber);

            for (int num = startingnumber; num <= endingnumber; num++)
            {
                int count = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && num != 1)
                {
                    Console.Write("{0} ", num);
                }
            }
            Console.WriteLine();
        }
    }
}