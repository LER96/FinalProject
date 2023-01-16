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
        public virtual Xdirect Xdirect { get; set; }
        public virtual Ydirect Ydirect { get; set; }
        public virtual UnitState State { get; set; }

        public virtual void SetTile(Tile tile)
        {
            //if the tile we set destenation to ,is empty
            if (tile.State == TileState.Empty)
            {
                this.unitTile.RemoveUnit();
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
            return $"Unit:{this.Name},Icon:{this.Icon}, Steps:{this.Steps}, Unit Type: {this.State}";
        }
    }

    public enum UnitState { Movable, Static}

    class MoveUnit: Unit,IMove, ICloneable<MoveUnit>
    {
        public MoveUnit(Player p, Tile tile,string name, string icon, Xdirect xMove, Ydirect yMove)
        {
            this.player = p;
            this.unitTile = tile;
            this.Name= name;
            this.Icon= icon;
            //this.Steps = dist;
            this.Xdirect = xMove;
            this.Ydirect = yMove;
            this.State = UnitState.Movable;
        }
        public MoveUnit Clone()
        {
            var moveU= (MoveUnit)MemberwiseClone();
            moveU.player = this.player;
            moveU.Name= this.Name;
            moveU.Icon= this.Icon;
            moveU.Steps= this.Steps;
            return moveU;
        }


        public void Move(int x, int y)
        {
            
        }
    }

    class StaticUnit : Unit, ICloneable<StaticUnit>
    {
        public StaticUnit(Player p, Tile tile, string name, string icon)
        {
            this.player = p;
            this.unitTile = tile;
            this.Name = name;
            this.Icon = icon;
            this.State = UnitState.Static;
        }

        // hard coded clone, a method that return the exact unit with his current settings
        public StaticUnit Clone()
        {
            var staticU= (StaticUnit)MemberwiseClone();
            staticU.player = this.player;
            staticU.Name= this.Name;
            staticU.Icon= this.Icon;
            staticU.State= this.State;
            return staticU;     
        }
    }
    public interface IMove
    {
        public void Move(int x, int y);
    }

    public enum Xdirect { Right, Left, Both, None}
    public enum Ydirect { Up, Down, Both, None}
    //For all types of clone 
    public interface ICloneable<T>
    {
        T Clone();
    }


}
