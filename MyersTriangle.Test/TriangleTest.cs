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
        [Test]
        public void Test_すべて1を渡したら正三角形と判定されること()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Equilateral));
        }

        [Test]
        public void Test_すべて2を渡したら正三角形と判定されること()
        {
            Triangle triangle = new Triangle(2, 2, 2);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Equilateral));
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
    }
}
