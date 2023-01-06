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
        protected virtual int Xlocation { get; set; }
        protected virtual int Ylocation { get; set; }

        public Action <Tile> actionState= (Tile t)=>Console.WriteLine($"Tile: {t.Xlocation},{t.Ylocation} is {t.State}");

        public virtual void SetUnit(Unit unit)
        {
            this.unit = unit;
            this.State = TileState.Occupied;
            actionState.Invoke(this);
            
        }
        public virtual void RemoveUnit()
        {
            this.unit = null;
            this.State = TileState.Empty;
            actionState.Invoke(this);
        }

        public string ToString()
        {
            return $"Tile states: {this.Color}, {this.State},{this.Xlocation},{this.Ylocation}";
        }
        public bool Equals(Tile t)
        {
            return (this.Xlocation==t.Xlocation && this.Ylocation== t.Ylocation) || this.unit.player.Equals(t.unit.player);
        }
    }


    public enum TileColor { White, Black, Green, Blue }
    public enum TileState { Occupied, Empty}
}
