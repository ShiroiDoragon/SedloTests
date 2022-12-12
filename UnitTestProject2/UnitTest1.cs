using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SedloTests;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestMin
{
    [TestClass]
    public class UnitTest
    {
        int[,] Matr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        [TestMethod]
        public void TestMinRow()
        {
            Sedlo sedlo = new Sedlo(Matr);
            var minMatr = sedlo.Min('r');
            int[] myMin = new int[] { 1, 4, 7 };
            CollectionAssert.AreEqual(myMin, minMatr);
        }

        [TestMethod]
        public void TestMinCol()
        {
            Sedlo sedlo = new Sedlo(Matr);
            var minMatr = sedlo.Min('c');
            int[] myMin = new int[] { 1, 2, 3 };
            CollectionAssert.AreEqual(myMin, minMatr);
        }

        [TestMethod]
        public void TestMaxRow()
        {
            Sedlo sedlo = new Sedlo(Matr);
            var maxMatr = sedlo.Max('r');
            int[] myMax = new int[] { 3, 6, 9 };
            CollectionAssert.AreEqual(myMax, maxMatr);
        }

        [TestMethod]
        public void TestMaxCol()
        {
            Sedlo sedlo = new Sedlo(Matr);
            var maxMatr = sedlo.Max('c');
            int[] myMax = new int[] { 7, 8, 9 };
            CollectionAssert.AreEqual(myMax, maxMatr);
        }

        [TestMethod]
        public void TestMain()
        {
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("3\n1\n2\n3\n4\n5\n6\n7\n8\n9\n"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);                   
                    Program.Main();
                    var result = sw.ToString().Trim().Split('\n').Last();
                    Assert.AreEqual("0 2 3; 2 0 7;", result);
                }
            }
        }

        [TestMethod]
        public void TestSedlo()
        {
            Sedlo sedlo = new Sedlo(Matr);
            List<Point> goodPoints = new List<Point>();
            goodPoints.Add(new Point(0, 2, 3));
            goodPoints.Add(new Point(2, 0, 7));
            var goodhash = goodPoints.Select(item => item.HashPoint).ToArray();
            Array.Sort(goodhash);

            var badhash = sedlo.SedloPoints.Select(item => item.HashPoint).ToArray();
            Array.Sort(badhash);

            Assert.AreEqual(true, badhash.SequenceEqual(goodhash));
        }
    }
}



/*
            Sedlo sedlo = new Sedlo(matrix);
            List<Point> goodPoints = new List<Point>();
            goodPoints.Add(new Point(0, 2, 3));
            goodPoints.Add(new Point(2, 0, 7));
            //bool v = goodPoints == sedlo.SedloPoints;
            goodPoints.Should().BeEquivalentTo(sedlo.SedloPoints);
            //CollectionAssert.AreEquivalent(goodPoints, sedlo.SedloPoints);
*/