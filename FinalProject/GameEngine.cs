using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class GameEngine
    {
        public virtual Player[] players { get; set; }
        public virtual Grid grid { get; set; }
        public virtual void PreGame()
        {

        }
        public virtual void Battle()
        {

        }

    }

    class Game : GameEngine
    {

    }
}
