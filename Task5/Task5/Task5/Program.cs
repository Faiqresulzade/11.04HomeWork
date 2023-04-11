using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            PopPlayer<Player> popPlayer = new PopPlayer<Player>();
        }
    }
    class PopPlayer<T>
    {
        public List<T> Players { get; set; }
        public void Add(T player)
        {
            Players.Add(player);
        }
        public void Remove(T player)
        {
            Players.Remove(player);
        }
        public void Sort()
        {
            Players.Sort();
        }
    }

    class Player
    {
        public int Point { get; set; }
    }
}
