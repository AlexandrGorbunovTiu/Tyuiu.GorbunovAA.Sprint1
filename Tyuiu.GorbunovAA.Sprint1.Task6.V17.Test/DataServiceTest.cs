using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint1.Task6.V17.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "XXAXX";
            var res = ds.CheckPalindrome(x);
            Assert.AreEqual(res, true);
        }
    }
}
