using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Abstract;
using FinalProject.Interface;

namespace FinalProject.Inherit
{
    class GameEngine : BaseEngine
    {
        public override Grid Grid { get; set; }
        public override List<Player> Players { get ; set; }
        public GameEngine()
        {
            CreatePlayers();
            CreateBoard();
            CreateUnits();
            RenderBoard();
        }
        public override void CreatePlayers()
        {
            Players = new List<Player>() {
            new Player(1, "Player 1"),
            new Player(2, "Player 2")
            };

        }
        public override void CreateUnits()
        {
            Players[0].Units = new List<TileObject>()
            {
                new Unit(Players[0],"king",'k',Grid[new Position(0,1)]),
                new Unit(Players[0],"queen",'q',Grid[new Position(1,1)]),
            };
            Players[1].Units = new List<TileObject>()
            {
                new Unit(Players[1],"king",'k',Grid[new Position(5,5)]),
                new Unit(Players[1],"queen",'q',Grid[new Position(4,3)]),
            };
        }
        public override void CreateBoard()
        {
            Grid = new ChessGrid();
        }

        public override void RenderBoard()
        {
            Console.Clear();
            for (int i = 0; i < Grid.Height; i++)
            {
                for (int j = 0; j < Grid.Width; j++)
                {
                    Grid.map[i, j].Icon = "[ ]";
                    var Piece = Grid.map[i,j].TileObject;
                    if (Piece is not null)
                    {
               
                        Console.Write($"[{Piece.Icon}]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.WriteLine();
            }

        }
        public virtual void Battle() 
        {

        }
        protected virtual void RenderPos(Unit unit) 
        {
            foreach(var item in unit.CanPositions)
            {
                if((item.X<Grid.Width && item.X < Grid.Width) && (item.Y<Grid.Height && item.Y > 0))
                {
                    Grid[item].Color = Color.Red;
                }
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
