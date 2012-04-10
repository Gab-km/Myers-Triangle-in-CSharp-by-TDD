using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyersTriangle
{
    public class Triangle
    {
        private int p;
        private int p_2;
        private int p_3;

        public Triangle(int p, int p_2, int p_3)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
            this.p_3 = p_3;
        }

        public TriangleType GetTypeOfTriangle()
        {
            return TriangleType.Equilateral;
        }
    }
}
