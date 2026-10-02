using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint1.Task4.V22.Lib;
namespace Tyuiu.GluhovaUA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 9;
            double wait = (Math.Sqrt(x * y)) / (1 + Math.Pow((x + 2 * y), 2));
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res,0.001);

        }
    }
}