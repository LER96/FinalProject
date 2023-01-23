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
        public int X { get; set; }
        public int Y { get; set; }
        public Player Owner { get; set; }
        public string Name { get; set; }
        public char Icon { get; set; }
        public Tile Tile { get; set; }

        //public Unit(int x, int y, Player owner, string name, char icon, Tile tile)
        //{
        //    this.X = x;
        //    this.Y = y;
        //    this.Owner = owner;
        //    this.Name = name;
        //    this.Icon = icon;
        //    this.Tile = tile;
        //}

        public Unit()
        {
            this.X = 1;
            this.Y = 1;
            this.Owner = null;
            this.Name = "fuck";
            this.Icon = 'f';
            this.Tile = null;
        }

        public delegate void Move(int x, int y);
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
        public delegate void Move(int x, int y);
    }
    public enum MoveDirect { Positive, Negative, Both };
    public interface ICloneable<T>
    {
        T Clone();
    }



}
