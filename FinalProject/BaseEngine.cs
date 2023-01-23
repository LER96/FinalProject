using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class BaseEngine: IRenderer
    {
        public virtual Player[] Players { get; set; }
        public virtual Grid Grid { get; set; }


    }
}
