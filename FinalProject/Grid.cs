using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Grid : IEnumerable<Tile>
    {
        public virtual Tile[,] _map { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Tile this[IPosition position]
        {
            get { return _map[position.Y, position.X]; }
            set { _map[position.Y, position.X] = value; }
        }
        //public Grid(int width, int height)
        //{
        //    this.Width = width;
        //    this.Height = height;
        //    this._map = new Tile[height, width];
        //}

        public IEnumerator<Tile> GetEnumerator()
        {
            return new SpiralEnumerator(_map, Width, Height);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class SpiralEnumerator : IEnumerator<Tile>
    {
        private Tile[,] _map;
        private int _width;
        private int _height;
        private int _x;
        private int _y;
        private int _direction;
        private int _steps;
        private bool _isFirst;

        public SpiralEnumerator(Tile[,] map, int width, int height)
        {
            _map = map;
            _width = width;
            _height = height;
            _x = 0;
            _y = -1;
            _direction = 0;
            _steps = 1;
            _isFirst = true;
        }

        public Tile Current
        {
            get { return _map[_y, _x]; }
        }

        object IEnumerator.Current => Current;
        public void Dispose() { }

        public bool MoveNext()
        {
            if (_isFirst)
            {
                _isFirst = false;
                return true;
            }

            switch (_direction)
            {
                case 0: _x++; break;
                case 1: _y++; break;
                case 2: _x--; break;
                case 3: _y--; break;
            }

            _steps--;
            if (_steps == 0)
            {
                _direction = (_direction + 1) % 4;
                if (_direction == 0 || _direction == 2) _steps++;
            }

            return (_x >= 0 && _x < _width);
        }

        public void Reset() { }
    }
}
