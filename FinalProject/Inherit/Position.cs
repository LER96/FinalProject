using FinalProject.Interface;
using System.Runtime.CompilerServices;

namespace FinalProject.Inherit
{
    readonly struct Position : IPosition, IEquatable<Position>
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is Position position && Equals(position);
        //}

        public bool Equals(Position other)
        {
            return X == other.X &&
                   Y == other.Y;
        }

        public static Position operator +(Position a, Position b)
        {
            return new Position(a.X + b.X, a.Y + b.Y);
        }
        public static Position operator -(Position a, Position b)
        {
            return new Position(a.X - b.X, a.Y - b.Y);
        }
    }
}
