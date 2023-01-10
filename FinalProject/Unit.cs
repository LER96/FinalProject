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
            //if the tile we set destenation to ,is empty
            if (tile.State == TileState.Empty)
            {
                //if the unit(pawn) is on the board
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

        public string ToString()
        {
            return $"Unit:{this.Name},Icon:{this.Icon}, Steps:{this.Steps}, Score:{this.ScoreUnit}, Unit Type: {this.State}";
        }
    }

    public enum UnitState { Movable, Static}

    class MoveUnit: Unit,IMove, ICloneable<MoveUnit>
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
        public MoveUnit Clone()
        {
            var moveU= (MoveUnit)MemberwiseClone();
            moveU.player = this.player;
            moveU.Name= this.Name;
            moveU.Icon= this.Icon;
            moveU.ScoreUnit= this.ScoreUnit;
            moveU.Steps= this.Steps;
            return moveU;
        }

        public void Move()
        {

        }
    }

    class StaticUnit : Unit, ICloneable<StaticUnit>
    {
        public StaticUnit(Player p, string name, string icon, int worth)
        {
            this.player = p;
            this.Name = name;
            this.Icon = icon;
            this.ScoreUnit = worth;
            this.State = UnitState.Static;
        }

        // hard coded clone, a method that return the exact unit with his current settings
        public StaticUnit Clone()
        {
            var staticU= (StaticUnit)MemberwiseClone();
            staticU.player = this.player;
            staticU.Name= this.Name;
            staticU.Icon= this.Icon;
            staticU.ScoreUnit= this.ScoreUnit;
            staticU.State= this.State;
            return staticU;     
        }
    }
    public interface IMove
    {
        public void Move();
    }

    //For all types of clone 
    public interface ICloneable<T>
    {
        T Clone();
    }


}
