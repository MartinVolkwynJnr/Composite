using System;

namespace Composite
{

    /// <summary>
    /// Shape class
    /// <remarks>
    /// Implements generic IComparable interface
    /// </remarks>
    /// </summary>
    public class Shape : IComparable<Shape>
    {
        string name;

        // Constructor
        public Shape(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        // IComparable<Shape> Member
        public int CompareTo(Shape other)
        {
            return (this == other) ? 0 : -1;
        }
    }
}