using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using System.Transactions;

namespace FinalProject
{
    internal class RenderGame
    {
        public RenderGame()
        {
            StartChoice();
        }
        public void StartChoice()
        {
            WriteLine("Hi there welcome to GameBoard Engine: Choose the following");
            WriteLine("1)Create New Game\n2)Play Default Game\n3)Load Game\n4)Exit\nYour Choice: ");
        }
        public void BuildGrid()
        {
            Clear();
            WriteLine("Grid: Enter Width & Height\n");
        }
        public void BuildPlayer(int num)
        {
            Clear();
            WriteLine($"Player{num}: Enter Name, and Number of UNITS\n");
        }
        public void BuildUnit(string name,int num)
        {
            WriteLine($"{name}'s UNIT {num}:");
        }
        public void Battle()
        {

        }
    }
}
