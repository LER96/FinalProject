using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Grid : IEnumerable<Tile>
    {
        private Tile[,] _map;

        public Tile this[int index]
        {
            get { return _map[index / Width, index % Width]; }
            set { _map[index / Width, index % Width] = value; }
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            _map = new Tile[height, width];
        }

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

        //object IEnumerator.Current
        //{
        //    get
        //    {
        //        return Current;
        //    }
        //}

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
        public IEnumerable<Tile> GetIEnumerable()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _map.GetEnumerator();
        }

    }
}
