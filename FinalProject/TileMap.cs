namespace FinalProject
{
    public class TileMap : Grid
    {
        public TileMap(int width, int height)
        {
            base.Width = width;
            base.Height = height;
            base.map = new Tile[height, width];
        }
    }
}
