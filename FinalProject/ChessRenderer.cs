using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    
    public class ChessGrid : Grid, IRenderer
    {
        public override Tile[,] map { get; set; }
        public override int Width { get; set; } = 8;
        public override int Height { get; set; } = 8;


        public ChessGrid()
        {
            this.map = new Tile[Height, Width];
        }

        public void CreateBoard()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    this.map[i, j] = new ChessTile(i, j);
                }
            }
        }

        public void RenderBoard()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    var Piece = this.map[i, j].Unit;
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

        public void Update()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    var Piece = this.map[i, j].Unit;
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
    }

    public class ChessTile : Tile
    {
        public ChessTile(int y, int x)
        {
            X = x;
            Y = y;
        }
        
        public override void OnTileObjectEnter(Unit tileObject)
        {
            throw new NotImplementedException();
        }

        public override void OnTileObjectExit(Unit tileObject)
        {
            throw new NotImplementedException();
        }
    }
}
