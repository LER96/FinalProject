using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal interface IRenderer
    {
        public void CreatePlayers();
        public void CreateBoard();
        public void RenderBoard();
        public void Update();
    }
}
