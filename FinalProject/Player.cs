using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Player
    {
        int ID { get; set; }
        string Name { get; set; }

        List<Unit> units { get; set; }

        public Player(int iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }
        public Player()
        {

        }
    }
}
