using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Grid
    {
        public IPosition[] grid;
        public IPosition this[int X, int Y]
        {
            get { return this[Y, X]; }
            set { this[X, Y] = value; }
        }
        public Grid()
        {
            this.grid = new IPosition[30];
        }
    }
}
