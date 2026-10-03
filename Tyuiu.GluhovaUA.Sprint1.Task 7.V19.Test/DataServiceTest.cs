using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint1.Task7.V19.Lib;

namespace Tyuiu.GluhovaUA.Sprint1.Task_7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEXpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double wait = 90008.75598;
            double f = Math.Round(wait, 3);
            var res = ds.Calculate(x);
            Assert.AreEqual(f, res);
        }
    }
}


