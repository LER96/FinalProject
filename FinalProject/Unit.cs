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
        public Player player { get; set; }
        public  Tile unitTile { get; set; }
        public virtual string Name { get; set; }
        public virtual string Icon { get; set; }
        public virtual int Steps { get; set; }
        public virtual int ScoreUnit { get; set; }
        public virtual UnitState State { get; set; }

        public virtual void SetTile(Tile tile)
        {
            if (tile.State == TileState.Empty)
            {
                if (this.unitTile != null)
                {
                    this.unitTile.RemoveUnit();
                }
                this.unitTile = tile;
                this.unitTile.SetUnit(this);
            }
            else
            {
                if (this.unitTile.Equals(tile) == false)
                {
                    tile.RemoveUnit();
                    this.unitTile = tile;
                    this.unitTile.SetUnit(this);
                }
            }
        }
    }

    public enum UnitState { Movable, Static}

    class MoveUnit: Unit,IMove
    {
        public MoveUnit(Player p,string name, string icon, int dist, int worth)
        {
            this.player = p;
            this.Name= name;
            this.Icon= icon;
            this.ScoreUnit = worth;
            this.Steps = dist;
            this.State = UnitState.Movable;
        }
        public void Move()
        {

        }
    }

    class StaticUnit : Unit
    {
        public StaticUnit(Player p, string name, string icon, int worth)
        {
            this.player = p;
            this.Name = name;
            this.Icon = icon;
            this.ScoreUnit = worth;
            this.State = UnitState.Static;
        }
    }

    public interface IMove
    {
        public void Move();
    }


}
