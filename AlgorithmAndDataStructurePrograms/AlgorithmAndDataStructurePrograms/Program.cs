using AlgorithmAndDataStructurePrograms;
using System;

namespace AlgorithmAndDataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Algorithm and Structure Programs");
                Console.WriteLine("Enter a number Which Program Can Execute\n 1.Permutations \n 2. Binary Search \n 3. Insertion Sort \n 4. Bubble Sort \n 5. Merge Sort \n 6. Anagram Detection \n 7. Prime Numbers in Range \n 13. Unordered List \n 14. Ordered List \n 15. Simple Balanced parantheses \n 16. Simulate Bank Cash Counter \n 17. Palindrome-Checker \n 18. Exit");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Enter a word to find its permutations : ");
                        string str = Console.ReadLine();
                        Console.WriteLine("//////////////////////");
                        Permutations.Permuta(str, 0, str.Length - 1);
                        break;
                    case 2:
                        BinarySearch bin = new BinarySearch();
                        bin.BinarySort();
                        break;
                    case 3:
                        InsertionSorting insertion = new InsertionSorting();
                        insertion.InsertionSort();
                        break;
                    case 4:
                        BubbleSearch sort = new BubbleSearch();
                        int[] integers = { 9, 2, 4, 5 };
                        sort.BubbleSort(integers);
                        break;
                    case 5:
                        MergeSort mergeSort = new MergeSort();
                        int[] arr = { 33, 55, 22, 999, 66, 11, 99 };
                        Console.WriteLine("Intial Stage");
                        mergeSort.PrintArray(arr);
                        mergeSort.Sort(arr, 0, arr.Length - 1);
                        Console.WriteLine("Finally");
                        mergeSort.PrintArray(arr);
                        break;
                    case 6:
                        AnagramDetection an = new AnagramDetection();
                        an.AnagramDetector();
                        break;
                    case 7:
                        PrimeNumbersInRange pnr = new PrimeNumbersInRange();
                        pnr.PrimeNumbers();
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        UnOrderedList un = new UnOrderedList();
                        un.UnOrderedli();
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        BankCashCouter co = new BankCashCouter();
                        co.BankingCashCounter();
                        break;
                    case 17:
                        AlgorithmAndDataStructurePrograms.Utility.PalindromeChecker.Palindrome();
                        break;
                    case 18:
                        flag = false;
                        break;
                }
            }
        }
    }
}

