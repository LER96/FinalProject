using FinalProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Abstract
{
    abstract class BaseEngine : IRenderer
    {
        public virtual List<Player> Players { get; set; }
        public virtual Grid Grid { get; set; }
        public virtual void CreatePlayers() { }
        public virtual void CreateBoard() { }
        public virtual void CreateUnits() { }
        public virtual void Battle() { }
        protected virtual void RenderPos() { }
        public virtual void RenderBoard() { }
        public virtual void Update()
        {
            Battle();
            RenderBoard();
            RenderPos();
        }
        public virtual dynamic GetValue<T>(string command)
        {
            if (typeof(T) == typeof(int))
            {
                Console.Write(command);
                return int.Parse(Console.ReadLine());
            }
            else if (typeof(T) == typeof(string))
            {
                Console.Write(command);
                return Console.ReadLine();
            }
            else
            {
                return false;
            }
        }

    }
}
