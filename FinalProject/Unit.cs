using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Unit
    {
        private Tile unitTile;
        public Unit(Tile unitTile)
        {
            this.unitTile = unitTile;
            this.unitTile.State = TileState.Occupied;
            this.unitTile.SetUnit(this);
        }
        public virtual string Name { get; set; }
        public virtual UnitState State { get; set; }

    }

    public enum UnitState { Movable, Static}
}
