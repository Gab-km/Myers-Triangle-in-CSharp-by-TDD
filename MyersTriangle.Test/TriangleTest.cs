﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MyersTriangle;

namespace MyersTriangle.Test
{
    public class TriangleTest
    {
        [TestCase(1, 1, 1, TriangleType.Equilateral)]
        [TestCase(2, 2, 2, TriangleType.Equilateral)]
        [TestCase(2, 2, 1, TriangleType.Isosceles)]
        [TestCase(1, 3, 3, TriangleType.Isosceles)]
        [TestCase(4, 2, 3, TriangleType.Scalene)]
        [TestCase(3, 4, 5, TriangleType.Scalene)]
        [TestCase(1, 2, 0, TriangleType.Invalid)]
        public void 三角形を判定する(int side1, int side2, int side3, TriangleType resutl)
        {
            var triangle = new Triangle(side1, side2, side3);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(resutl));
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
