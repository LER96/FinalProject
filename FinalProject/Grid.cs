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
            for(int y=0; y<height; y++) 
            {
                for(int x=0; x<width; x++)
                {
                    tiles[y, x].State = TileState.Empty;
                    tiles[y, x].Xlocation = x;
                    tiles[y, x].Ylocation = y;
                }
            }
        }

        public int Distance(Tile startTile,Tile endTile)
        {
            int distanceX= endTile.Xlocation- startTile.Xlocation;
            int distanceY= endTile.Ylocation- startTile.Ylocation;

            if(distanceX<0)
            {
                distanceX*=-1;
            }
            if(distanceY<0)
            {
                distanceY*=-1;
            }

            return distanceX + distanceY;
        }

    }
}
