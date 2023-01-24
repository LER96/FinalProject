using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class TileObject : IMove, ICloneable<TileObject>
    {
        public IPosition CurrentPos { get; set;}
        public virtual Player Owner { get; set;}
        public virtual string Name { get; set;}
        public virtual char Icon { get; set;}
        public virtual Tile Tile { get; set;}

        public List<MoveSet> MoveSets { get; set; }
        public virtual void AddMoveSet(MoveSet moveset);

        public virtual TileObject Clone()
        {
            var u = (TileObject)MemberwiseClone();
            u.Owner = this.Owner;
            u.Name = this.Name;
            u.Icon = this.Icon;

            u.Owner = this.Owner;
            return u;
        }
    }

    public interface IMove
    {
        public List<MoveSet> MoveSets { get; set; }
        public void AddMoveSet(MoveSet moveset);
    }
    public enum MoveDirect { Positive, Negative, Both };
    public interface ICloneable<T>
    {
        T Clone();
    }



}
