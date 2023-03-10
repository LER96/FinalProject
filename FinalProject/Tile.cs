using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Tile
    {
        
        
        public int X { get; set; }
        public int Y { get; set; }
        public Unit Unit { get; set; }

        public abstract void OnTileObjectEnter(Unit tileObject);
        public abstract void OnTileObjectExit(Unit tileObject);
    }

}
