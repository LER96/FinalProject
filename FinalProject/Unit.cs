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
        public virtual Tile unitTile { get; set; }
        public virtual string Name { get; set; }
        public virtual string Icon { get; set; }
        public virtual int Steps { get; set; }
        public virtual int ScoreUnit { get; set; }
        public virtual UnitState State { get; set; }
        public virtual void SetTile(Tile tile)
        {
            if (tile.State == TileState.Empty)
            {
                this.unitTile = tile;
                this.unitTile.State = TileState.Occupied;
                this.unitTile.SetUnit(this);
            }
        }
    }

    public enum UnitState { Movable, Static}

    class MoveUnit: Unit
    {
        public MoveUnit(string name, int dist, int worth)
        {
            this.Name= name;
            this.ScoreUnit = worth;
            this.Steps = dist;
            this.State = UnitState.Movable;
        }

        //Layan
        public void Move()
        {

        }
    }

    class StaticUnit : Unit
    {
        public StaticUnit(string name, int worth)
        {
            this.Name = name;
            this.ScoreUnit = worth;
            this.State = UnitState.Static;
        }
    }


}
