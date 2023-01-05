using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Tile
    {
        public Unit unit;
        public virtual TileColor Color { get; set; }
        public virtual TileState State { get; set; }

        public virtual int Xlocation { get; set; }
        public virtual int Ylocation { get; set; }

        public virtual void SetUnit(Unit unit)
        {
            this.unit = unit;
        }
    }




    public enum TileColor { White, Black, Green, Blue }
    public enum TileState { Occupied, Empty}
}
