using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class GameEngine: BaseEngine
    {
        public GameEngine()
        {
            CreatePlayers();
        }
        public override void CreatePlayers()
        {
            for (int i = 0; i < Players.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Player{i + 1} states:");
                Players[i] = new Player(base.GetValue<int>("Give Units:")
                    , base.GetValue<int>("Give ID:"),
                    base.GetValue<string>("What's your name?:"));
            }
        }
        //public override dynamic GetValue<T>(string command)
        //{
        //    if (typeof(T) == typeof(int))
        //    {
        //        return int.Parse(Console.ReadLine());
        //    }
        //    else if (typeof(T) == typeof(string))
        //    {
        //        return Console.ReadLine();
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }


}
