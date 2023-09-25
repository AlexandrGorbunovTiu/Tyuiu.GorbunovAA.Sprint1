using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, 1,111);

        }
    }
}
