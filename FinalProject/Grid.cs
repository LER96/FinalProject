﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Grid//: IEnumerable<Tile>
    {
        Tile[,] tiles;
        public Grid(int width, int height)
        {
            tiles = new Tile[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    tiles[y, x].State = TileState.Empty;
                    tiles[y, x].Xlocation = x;
                    tiles[y, x].Ylocation = y;
                }
            }
        }

        public int Distance(Tile startTile, Tile endTile)
        {
            int distanceX = endTile.Xlocation - startTile.Xlocation;
            int distanceY = endTile.Ylocation - startTile.Ylocation;

            if (distanceX < 0)
            {
                distanceX *= -1;
            }
            if (distanceY < 0)
            {
                distanceY *= -1;
            }

            return distanceX + distanceY;
        }
        //int height, width;

        //public IEnumerator<Tile> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

    }
}

//    class SetTile : IEnumerator<Tile>
//    {
//        Tile[,] tiles;
//        int x=-1, y=-1;
//        int count = 1;
//        int direct = 0;
//        bool flag;
//        public SetTile(Tile[,] gridTile, int height, int width)
//        {
//            tiles= gridTile;
//            x = width;
//            y = height;
//        }

//        public Tile Current
//        {
            
//            get
//            {
//                switch (direct)
//                {
//                    //Up
//                    case 0:
//                        return tiles[y, x];
//                    //Right
//                    case 1:
//                        return tiles[y, x];
//                    //Down
//                    case 2:
//                        return tiles[y, x];
//                    //Left
//                    case 3:
//                        return tiles[y, x];
                        
//                }
//            }

//        }

//        object IEnumerator.Current => throw new NotImplementedException();

//        public bool MoveNext()
//        {
//            x++;
//            y++;
//            return x < tiles.GetLength(1) && y<tiles.GetLength(0);
//        }
//        public void Dispose()
//        {
           
//        }
//        public void Reset()
//        {
            
//        }
//    }
//}
