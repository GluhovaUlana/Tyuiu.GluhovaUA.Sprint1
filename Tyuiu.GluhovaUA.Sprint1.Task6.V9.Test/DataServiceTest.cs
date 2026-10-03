using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GluhovaUA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.GluhovaUA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string x = "abc";
            string wait = "cab";
            var res = ds.MoveLetterToStart(x);
            Assert.AreEqual(wait, res);

        }
    }
}

