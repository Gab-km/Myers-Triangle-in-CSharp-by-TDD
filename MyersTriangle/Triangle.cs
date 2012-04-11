using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyersTriangle
{
    public class Triangle
    {
        private int _side1;
        private int _side2;
        private int _side3;

        public Triangle(int side1, int side2, int side3)
        {
            // TODO: Complete member initialization
            this._side1 = side1;
            this._side2 = side2;
            this._side3 = side3;
        }

        public TriangleType GetTypeOfTriangle()
        {
            if (this._side1 == this._side2 && this._side1 == this._side3)
                return TriangleType.Equilateral;
            else
                return TriangleType.Isosceles;
        }
    }
}
