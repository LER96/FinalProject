using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Interface;

namespace FinalProject.Abstract
{
    public abstract class Tile
    {
        public virtual IPosition Position { get; set; }
        public virtual object Color { get; set; }
        public virtual TileObject? TileObject { get; set; }


    }

}
