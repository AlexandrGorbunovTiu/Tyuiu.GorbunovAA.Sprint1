using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GorbunovAA.Sprint1.Task0.V20.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(res, 13);
        }
    }
}
