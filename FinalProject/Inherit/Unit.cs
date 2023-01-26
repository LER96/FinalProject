using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Abstract;

namespace FinalProject.Inherit
{
    internal class Unit : TileObject
    {
        public override Position CurrentPos { get; set; }
        public override Player Owner { get; set; }
        public override string Name { get; set; }
        public override char Icon { get; set; }
        public override Tile Tile { get; set; }
        public override List<Position> CanPositions { get; set; }
        public Unit(Player p, string n, char i, Tile t)
        {
            this.Owner= p;
            this.Name= n;
            this.Icon= i;
            this.Tile= t;
            t.TileObject = this;
            this.CurrentPos = t.Pos;
        }
        public override void AddMove(Position a)
        {

            CanPositions.Add(PossibleMove(a));
        }
        protected override Position PossibleMove(Position a)
        {
            return a + CurrentPos;
        }

    }
}
