using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Inventory<T> 
    {
        public List<T> Elements { get; set; }

        public void Add(T item)
        {
            Elements.Add(item);
        }
        public void Remove(T item)
        {
            Elements.Remove(item);
        }
        public void Sort()
        {
            Elements.Sort();
        }
    }
}
