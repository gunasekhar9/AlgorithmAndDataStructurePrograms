using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmAndDataStructurePrograms
{
    class InsertionSorting
    {
        public void InsertionSort()
        {
            string text = File.ReadAllText(@"C:\Users\gunas\OneDrive\Documents\Git Problems\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\Files\InsertionSort.txt");
            string[] data = text.Split(" ");
            string temp;
            Console.WriteLine("Initially");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            for (int i = 1; i < data.Length; i++)
            {
                temp = data[i];
                int j = i - 1;
                while (j >= 0 && data[j].CompareTo(temp) > 0)
                {
                    data[j + 1] = data[j];
                    j--;
                }
                data[j + 1] = temp;
            }
            Console.WriteLine("Finally");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}