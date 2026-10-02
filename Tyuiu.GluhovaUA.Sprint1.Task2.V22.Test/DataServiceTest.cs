using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint1.Task2.V22.Lib;
namespace Tyuiu.GluhovaUA.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 6;
            int z = 4;
            var res = ds.CalculateAVGValue(x, y, z);
            Assert.AreEqual(4, res);

        }
    }
}
