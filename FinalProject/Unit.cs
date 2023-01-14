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
        public Grid TileMap { get; set; }
        public virtual string Name { get; set; }
        public virtual string Icon { get; set; }
        public virtual int ScoreUnit { get; set; }
        public virtual UnitState State { get; set; }

        
    }

    public enum UnitState { Movable, Static}

    class MoveUnit: Unit,IMove, ICloneable<MoveUnit>
    {
        
        public MoveUnit Clone()
        {
            var moveU= (MoveUnit)MemberwiseClone();
            moveU.player = this.player;
            moveU.Name= this.Name;
            moveU.Icon= this.Icon;
            moveU.ScoreUnit= this.ScoreUnit;
            return moveU;
        }
        public void Move()
        {

        }
    }

    class StaticUnit : Unit, ICloneable<StaticUnit>
    {
        
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
    public interface ICloneable<T>
    {
        T Clone();
    }


}
