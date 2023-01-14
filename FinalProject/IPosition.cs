using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class IPosition
    {
        public int X;
        public int Y;
        public Tile Tile;
        public IPosition(int x, int y, Tile tile)
        {
            this.X = x;
            this.Y = y;
            this.Tile = tile;
        }

        public string ToString()
        {
            return $"Location:{this.X},{this.Y}";
        }
        public bool Equals(IPosition pos)
        {
            return this.X == pos.X && this.Y == pos.Y;
        }
        public int GetHashCode(IPosition pos)
        {
            return pos.X.GetHashCode() ^ pos.Y.GetHashCode();
        }

    }
}
