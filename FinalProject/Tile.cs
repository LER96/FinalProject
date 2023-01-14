using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Tile
    {
        public Unit Unit { get; set; }
        public StateTile State { get; set; }

        public Tile()
        {
            State = StateTile.Empty;
        }

    }

    public enum StateTile { Empty, Occupied, Hole}

}
