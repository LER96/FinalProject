using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Inherit;
using FinalProject.Interface;

namespace FinalProject.Abstract
{
    public abstract class TileObject : IMove, ICloneable<TileObject>
    {
        public virtual Position CurrentPos { get; set; }
        public virtual Player Owner { get; set; }
        public virtual string Name { get; set; }
        public virtual char Icon { get; set; }
        public virtual Tile Tile { get; set; }
        //public List<MoveSet> MoveSets { get; set; }
        //public virtual void AddMoveSet(MoveSet moveset) { }
        public virtual List<Position> CanPositions { get; set; }
        public virtual void  AddMove(Position a) 
        {
            CanPositions.Add(a);
        }

        public virtual TileObject Clone()
        {
            var u = (TileObject)MemberwiseClone();
            u.Owner = Owner;
            u.Name = Name;
            u.Icon = Icon;

            u.Owner = Owner;
            return u;
        }
    }

    public interface IMove
    {
        //public List<MoveSet> MoveSets { get; set; }
        //public void AddMoveSet(MoveSet moveset);
        public List<Position> CanPositions { get; set; }
        public void AddMove(Position a);
    }
    //public enum MoveDirect { Positive, Negative, Both };
    public interface ICloneable<T>
    {
        T Clone();
    }



}
