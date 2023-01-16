using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class GameEngine
    {
        public RenderGame render;
        public Grid grid;
        public Player[] players= new Player[2];
        public GameEngine()
        {
            render = new RenderGame();
        }
        public virtual void PreGame(int choice)
        {
            switch(choice)
            {
                case 1:
                    BuildGrid();
                    break;
            }
        }
        public virtual void BuildGrid()
        {
            render.BuildGrid();
            int width= GiveInput();
            int height= GiveInput();
            grid = new Grid(width, height);
            if(Continue())
            {
                BuildPlayer();
            }
            else
            {
                BuildGrid();
            }
        }
        public virtual void BuildPlayer()
        {
            for (int i = 0; i < players.Length; i++)
            {
                render.BuildPlayer(i);
                string name = Console.ReadLine();
                int count = GiveInput();
                players[i].Name = name;
                players[i].units = new Unit[count];

                if (Continue())
                {
                    for (int j = 0; j < count; j++)
                    {
                        BuildUnit(name,j);
                    }
                }
                else
                {
                    BuildPlayer();
                }
            }

        }
        public virtual void BuildUnit(string name,int j)
        {
            render.BuildUnit(name,j);

        }

        public virtual void GameSession()
        {

        }

        public virtual bool Continue()
        {
            Console.WriteLine("Press Enter to Continue");
            ConsoleKeyInfo key = Console.ReadKey(true);
            ConsoleKey k = key.Key;
            if (k== ConsoleKey.Enter)
            {
                return true;
            }
            else
                return false;
        }
        public int GiveInput()
        {
            return int.Parse(Console.ReadLine());
        }

    }
}
