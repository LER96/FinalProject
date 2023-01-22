using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class NewUnit: Unit
    {
        public NewUnit() 
        {

        }

        public override void OnTileEnter(Tile tile)
        {
            throw new NotImplementedException();
        }

        public override void OnTileExit(Tile tile)
        {
            throw new NotImplementedException();
        }

        public delegate void Move(int x, int y);
    }
}
