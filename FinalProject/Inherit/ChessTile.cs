using FinalProject.Abstract;

namespace FinalProject.Inherit
{
    public class ChessTile : Tile
    {

        public ChessTile(int y, int x)
        {
            Pos = new Position(x, y);
        }
    }
}
