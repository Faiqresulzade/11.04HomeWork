using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject<int> gameObject1 = new GameObject<int>
            {
                Healthy = 100
            };
            GameObject<int> gameObject2 = new GameObject<int>
            {
                Healthy = 100
            };
            HighHealthy<int>(gameObject1, gameObject2);
        }

        public static GameObject<T> HighHealthy<T>(GameObject<T> gameObject1,GameObject<T> gameObject2)
        {
            if (gameObject2.Healthy == gameObject1.Healthy) return null;
            if (gameObject2.Healthy > gameObject1.Healthy) return gameObject2;
            return gameObject1;
        }
    }

    class GameObject<T>
    {
        public int Healthy { get; set; }
    }
}
