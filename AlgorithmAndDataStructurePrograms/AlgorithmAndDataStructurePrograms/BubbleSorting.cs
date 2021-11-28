﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructurePrograms
{
    public class BubbleSearch
    {
        public void BubbleSort(int[] integers)
        {
            int temp;
            Console.WriteLine("Initially");
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
            }
            for (int i = 0; i < integers.Length - 1; i++)
            {
                for (int j = 0; j < integers.Length - i - 1; j++)
                {
                    if (integers[j] > integers[j + 1])
                    {
                        temp = integers[j];
                        integers[j] = integers[j + 1];
                        integers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting");
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i] + " ");
            }
        }
    }
}  