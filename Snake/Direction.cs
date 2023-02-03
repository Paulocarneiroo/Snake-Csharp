using System;
using System.Collections.Generic;

namespace Snake
{
    public class Direction : IEquatable<Direction>
    {
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);

        public int rowOffset { get; }
        public int colOffset { get; }

        private Direction(int rowOffset, int colOffset)
        {
            this.rowOffset = rowOffset;
            this.colOffset = colOffset;
        }

        public Direction opposite()
        {
            return new Direction(-rowOffset, -colOffset);
        }

        public override bool Equals(object obj)
        {
            return obj is Direction direction &&
                   rowOffset == direction.rowOffset &&
                   colOffset == direction.colOffset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(rowOffset, colOffset);
        }

        public static bool operator ==(Direction left, Direction right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction left, Direction right)
        {
            return !(left == right);
        }
    }
}
