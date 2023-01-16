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

        public Tile(TileColor color, TileState state)
        {
            Color = color;
            State = state;
        }

        public Action<Tile> actionState = (Tile t) => Console.WriteLine($"Tile: is {t.State}");

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
            return $"Tile states: {this.Color}, {this.State},{this.unit.ToString()}";
        }

    }

    public enum TileColor { White, Black, Green, Blue }
    public enum TileState { Occupied, Empty}
}
