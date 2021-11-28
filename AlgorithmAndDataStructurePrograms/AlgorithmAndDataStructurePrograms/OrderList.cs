using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/*namespace AlgorithmAndDataStructurePrograms
{
    public class OrderList
    {
        public void Orderedli()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            string text = File.ReadAllText(@"C:\Users\gunas\OneDrive\Documents\Git Problems\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\Files\OrderedList.txt");
            int[] numbers int text.Split(",");
            Console.WriteLine("Lenth of text is is {0}", numbers.Length);
            foreach (int item in numbers)
            {
                linkedList.AddLast(item);
            }
            Display(linkedList);
            Console.WriteLine("Enter the number to Search");
            int search = Console.ReadLine();
            if (linkedList.Contains(search))
            {
                linkedList.Remove(search);
                Console.WriteLine("{0} is removed from the file", search);
            }
            else
            {
                linkedList.AddLast(search);
                Console.WriteLine("{0} is added from the file", search);
            }
            File.WriteAllText(@"C:\Users\gunas\OneDrive\Documents\Git Problems\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\AlgorithmAndDataStructurePrograms\Files\OrderedList.txt", text);
            Display(linkedList);
        }
        private void Display(LinkedList<int> linkedList)
        {
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}*/