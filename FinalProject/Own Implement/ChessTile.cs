using FinalProject.Abstract;

namespace FinalProject.Inherit
{
    public class ChessTile : Tile
    {
        public override Position Pos { get; set; }
        public override object Color { get; set; }
        public override string Icon { get; set; }
        public override TileObject? TileObject { get; set; }
        public ChessTile(int y, int x)
        {
            Pos = new Position(x, y);
        }
    }
}
