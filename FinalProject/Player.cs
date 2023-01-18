using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Player
    {
        public virtual Unit[] Units { get; set; }
        public virtual string Name { get; set; }
        public virtual string Score { get; set; }

    }
}
