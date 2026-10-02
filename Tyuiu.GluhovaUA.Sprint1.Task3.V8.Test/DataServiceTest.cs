using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.GluhovaUA.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2500.0;
            double y = 20.0;
            double z =30.0;
            double wait = 2541.100;
            var res = ds.IncomeAmount(x, y, z);
            Assert.AreEqual(wait,res, 0.001);
        }
    }
}
