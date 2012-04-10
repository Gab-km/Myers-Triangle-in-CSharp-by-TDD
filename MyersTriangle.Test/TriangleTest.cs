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
        [Test]
        public void Test_すべて1を渡したら正三角形と判定されること()
        {
            Triangle triangle = new Triangle(1, 1, 1);
            Assert.That(triangle.GetTypeOfTriangle(), Is.EqualTo(TriangleType.Equilateral));
        }
    }
}