using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint1.Task7.V30.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0; double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 1,2);

        }
    }
}
