using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 0;
            double x2 = 5;
            double y2 = 0;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(res,4);
        }
    }
}
