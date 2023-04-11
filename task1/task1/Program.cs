using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class GameObject<T>
    {
        public List<T>GameObjects { get; set; }

        public void AddObject(T gameObject)
        {
            GameObjects.Add(gameObject);
        }
    }
}
