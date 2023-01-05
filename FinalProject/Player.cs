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
        public virtual Unit[] units { get; set; }

        public virtual int Score { get; set; }

    }
}
