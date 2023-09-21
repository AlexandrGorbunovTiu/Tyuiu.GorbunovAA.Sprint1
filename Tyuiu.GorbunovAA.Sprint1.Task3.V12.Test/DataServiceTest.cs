using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.GorbunovAA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5; 
            int y = 4;
            int wait = 10;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
