using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Abstract;

namespace FinalProject.Inherit
{
    class GameEngine : BaseEngine
    {
        public override Grid Grid { get => base.Grid; set => base.Grid = value; }
        public override Player[] Players { get => base.Players; set => base.Players = value; }
        public GameEngine()
        {
            CreatePlayers();
            CreateBoard();
        }
        public override void CreatePlayers()
        {
            Players[0] = new Player(16, 1, "Player 1");
            Players[0] = new Player(16, 2, "Player 2");
        }
        public override void CreateUnits()
        {
            Players[0].Units = new List<TileObject>
            {
                new Unit(),
                new Unit()
            };
        }
        public override void CreateBoard()
        {
            Grid = new ChessGrid();
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
