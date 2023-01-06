using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Player
    {
        public virtual string Name { get; set; }
        public virtual List<Unit> units { get; set; }

        public virtual int Score { get; set; }

        public string ToString()
        {
            return $"Player:{this.Name}, Units{this.units.Count}, Score:{this.Score}";
        }
        public bool Equals(Player p)
        {
           return this.Name == p.Name && this.units.SequenceEqual(p.units);
        }

    }
}
