using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class BaseEngine: IRenderer
    {
        public virtual Player[] Players { get; set; }= new Player[2];
        public virtual Grid Grid { get; set; }

        public virtual void CreatePlayers()
        {

        }
        public virtual void CreateBoard()
        {

        }
        public virtual void CreateUnits()
        {

        }

        public virtual void RenderBoard()
        {

        }
        public virtual void Update()
        {
            RenderBoard();
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
