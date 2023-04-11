using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface Character<T>
    {
        public void Attacking<T>(T gamer);
        public void TakingDamage<T>(T enemy);
        public void Healing<T>(T gamer);

    }
}
