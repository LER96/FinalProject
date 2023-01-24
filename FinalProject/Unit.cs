using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Unit : IMove, ICloneable<Unit>
    {
        public IPosition CurrentPos { get; set; }
        public Player Owner { get; set; }
        public string Name { get; set; }
        public char Icon { get; set; }
        public Tile Tile { get; set; }

        public virtual IPosition Move(int x, int y)
        {
            Position pos = new Position(x, y); 
            return pos;
        }
        public abstract void OnTileEnter(Tile tile);
        public abstract void OnTileExit(Tile tile);

        public virtual Unit Clone()
        {
            var u = (Unit)MemberwiseClone();
            u.Owner = this.Owner;
            u.Name = this.Name;
            u.Icon = this.Icon;

            u.Owner = this.Owner;
            return u;
        }
    }

    public interface IMove
    {
        public IPosition Move(int x, int y);
    }
    public enum MoveDirect { Positive, Negative, Both };
    public interface ICloneable<T>
    {
        T Clone();
    }



}
