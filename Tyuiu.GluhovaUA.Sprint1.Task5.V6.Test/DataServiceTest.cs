using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.GluhovaUA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 1;
            int wait = 1;
            var res = ds.Calculate(k);
            Assert.AreEqual(wait, res);

        }
    }
}
