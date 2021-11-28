using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructurePrograms
{
    public class AnagramDetection
    {
        public void AnagramDetector()
        {
            string st1 = "abcd";
            string st2 = "dcba";
            Char[] ch1 = st1.ToLower().ToCharArray();
            char[] ch2 = st2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("(Yes) Those Two {0} and {1} Strings are Anagrams", st1 , st2);
            }
            else
                Console.WriteLine("(N0) Those Two Strings are not Anagrams", st1 , st2);
        }

    }
}
