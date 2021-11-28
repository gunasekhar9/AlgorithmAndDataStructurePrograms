using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructurePrograms.Utility
{
    public class Node<T> where T : IComparable
    {
        public T data;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
        }

        public Node(int data1)
        {
        }
    }
}