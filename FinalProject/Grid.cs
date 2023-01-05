using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Grid
    {
        Tile[,] tiles;
        public Grid(int width, int height)
        {
            tiles = new Tile[width, height];
            for(int i=0; i<width; i++) 
            {
                for(int j=0; j<height; j++)
                {
                    tiles[i, j].State = TileState.Empty;
                }
            }
        }
    }
}
