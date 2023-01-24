using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Interface
{
    internal interface IRenderer
    {
        public void CreatePlayers();
        public void CreateBoard();
        public void CreateUnits();
        public void RenderBoard();
        public void Update();
    }
}
