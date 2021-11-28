using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmAndDataStructurePrograms
{
    public class UnOrderedList
    {
        public void UnOrderedli()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            string text = File.ReadAllText(@"C:\Users\gunas\OneDrive\Documents\Git Problems\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\Files\UnorderList.txt");
            string[] words = text.Split(",");
            Console.WriteLine("Length of the text is {0}", words.Length);
            foreach (string item in words)
            {
                linkedList.AddLast(item);
            }
             void Display(LinkedList<string> linkedList)
            {
                foreach (var item in linkedList)
                {
                    Console.WriteLine(item);
                }
            }
            Display(linkedList);
            Console.WriteLine("Enter the word to search");
            string search = Console.ReadLine();
            if (linkedList.Contains(search))
            {
                linkedList.Remove(search);
                Console.WriteLine("{0} is removed from the File", search);
            }
            else
            {
                linkedList.AddLast(search);
                Console.WriteLine("{0} is added in the File", search);
            }
            File.WriteAllText(@"C:\Users\gunas\OneDrive\Documents\Git Problems\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\Files\UnorderList.txt", text);
            Display(linkedList);
        }
    }
}  