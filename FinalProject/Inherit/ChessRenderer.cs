using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Abstract;

namespace FinalProject.Inherit
{
    public class ChessGrid : Grid
    {
        public override Tile[,] map { get; set; }
        public override int Width { get; set; } = 8;
        public override int Height { get; set; } = 8;


        public ChessGrid()
        {
            this.map = new Tile[Height, Width];
            CreateBoard();
        }

        public void CreateBoard()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    map[i, j] = new ChessTile(i, j);
                }
            }
        }

        //public void RenderBoard()
        //{
        //    Console.Clear();
        //    for (int i = 0; i < Height; i++)
        //    {
        //        for (int j = 0; j < Width; j++)
        //        {
        //            var Piece = map[i, j].TileObject;
        //            if (Piece is not null)
        //            {
        //                Console.Write($"[{Piece.Icon}]");
        //            }
        //            else
        //            {
        //                Console.Write("[ ]");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
