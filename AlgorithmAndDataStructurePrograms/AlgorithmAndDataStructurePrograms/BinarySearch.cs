using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmAndDataStructurePrograms
{
    public class BinarySearch
    {
        public void BinarySort()
        {
            string text = File.ReadAllText(@"C:\Users\gunas\OneDrive\Documents\Git Problems\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\Files\Binary.txt");
            List<string> words = new List<string>(text.Split(","));
            words.Sort();
            Binary(words);
        }
        public void Binary(List<string> words)
        {
            Console.WriteLine("Enter the element to search : ");
            string search = Console.ReadLine();
            int low = 0, high = words.Count - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int result = search.CompareTo(words[mid]);
                if (result == 0)
                {
                    Console.WriteLine("Element is found at index : {0}", mid);
                    return;
                }
                else if (result > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            Console.WriteLine("Element is not present");
        }
    }
}