using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Grid : IPosition<Tile>//: IEnumerable<Tile>
    {
        public virtual Tile[,] TileMap { get; set; }

        public Tile this[int x, int y]
        {
            get { return TileMap[y, x]; }
            set { TileMap[y, x] = value; }
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
