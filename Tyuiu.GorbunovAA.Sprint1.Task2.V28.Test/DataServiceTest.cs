using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint1.Task2.V28.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 7;
            var res = ds.ConvertCelsiusToKelvin(x);
            Assert.AreEqual(res, 280);
        }
    }
}
