using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Unit : IMove, ICloneable<Unit>
    {
        public Player player { get; set; }
        public Tile UnitTile { get; set; }
        public virtual string Name { get; set; }
        public virtual string Icon { get; set; }
        public virtual int ScoreUnit { get; set; }
        public Action<Unit> Action = (Unit t) => { Console.WriteLine($"{t.player}:{t.Name} is at {t.UnitTile}"); };

        public virtual void Move(int x, int y)
        {

        }
        public virtual Unit Clone()
        {
            var u = (Unit)MemberwiseClone();
            u.Name = this.Name;
            u.Icon = this.Icon;
            u.ScoreUnit = this.ScoreUnit;

            u.player = this.player;
            u.UnitTile = this.UnitTile;

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
