using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Unit : IMove, ICloneable<Unit>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public IPlayer Owner { get; set; }
        public string Name { get; set; }
        public char Icon { get; set; }
        public abstract void Move(int x, int y);
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
        public void Move(int x, int y);
    }
    public interface ICloneable<T>
    {
        T Clone();
    }



}
