using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberUnits { get; set; }
        public List<TileObject> Units { get; set; }

        public Player(int iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }
        public Player(int units, int id, string name)
        {
            this.ID=id;
            this.Name = name;
            this.NumberUnits= units;
        }
    }
}
