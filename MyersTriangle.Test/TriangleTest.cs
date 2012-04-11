using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MyersTriangle;

namespace MyersTriangle.Test
{
    public class TriangleTest
    {
        [TestCase(1,1,1,TriangleType.Equilateral)]
        [TestCase(2,2,2,TriangleType.Equilateral)]
        public void 三角形を判定する(int side1,int side2,int side3, TriangleType resutl)
        {
            var triangle = new Triangle(side1, side2, side3);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(resutl));
        }

        [Test]
        public void Test_2と2と1を渡したら二等辺三角形と判定されること()
        {
            var triangle = new Triangle(2, 2, 1);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Isosceles));
        }

        [Test]
        public void Test_1と3と3を渡したら二等辺三角形と判定されること()
        {
            var triangle = new Triangle(1, 3, 3);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Isosceles));
        }

        [Test]
        public void Test_4と2と3を渡したら不等辺三角形と判定されること()
        {
            var triangle = new Triangle(4, 2, 3);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Scalene));
        }

        [Test]
        public void Test_3と4と5を渡したら不等辺三角形と判定されること()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Scalene));
        }

        [Test]
        public void Test_1と2と0を渡したら三角形でないと判定されること()
        {
            var triangle = new Triangle(1, 2, 0);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Invalid));
        }

        [Test]
        public void Test_3と0と5を渡したら三角形でないと判定されること()
        {
            var triangle = new Triangle(3, 0, 5);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Invalid));
        }

        [Test]
        public void Test_1と1と2を渡したら三角形でないと判定されること()
        {
            var triangle = new Triangle(1, 1, 2);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Invalid));
        }

        [Test]
        public void Test_3と6と2を渡したら三角形でないと判定されること()
        {
            var triangle = new Triangle(3, 6, 2);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Invalid));
        }

        [Test]
        public void Test_minus1と4と5を渡したら三角形でないと判定されること()
        {
            var triangle = new Triangle(-1, 4, 5);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Invalid));
        }
    }
}
