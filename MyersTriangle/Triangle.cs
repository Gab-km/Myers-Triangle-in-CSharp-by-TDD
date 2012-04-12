using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyersTriangle
{
    public class Triangle
    {
        private decimal _side1;
        private decimal _side2;
        private decimal _side3;

        public Triangle(decimal side1, decimal side2, decimal side3)
        {
            this._side1 = side1;
            this._side2 = side2;
            this._side3 = side3;
        }

        public TriangleType GetTypeOfTriangle()
        {
            if (this._side1 + this._side2 > this._side3
                && this._side2 + this._side3 > this._side1
                && this._side3 + this._side1 > this._side2)
            {
                if (this._side1 == this._side2 && this._side1 == this._side3)
                    return TriangleType.Equilateral;
                else if (this._side1 == this._side2
                    || this._side2 == this._side3
                    || this._side3 == this._side1)
                    return TriangleType.Isosceles;
                else
                    return TriangleType.Scalene;
            }
            else
                return TriangleType.Invalid;
        }
    }
}
