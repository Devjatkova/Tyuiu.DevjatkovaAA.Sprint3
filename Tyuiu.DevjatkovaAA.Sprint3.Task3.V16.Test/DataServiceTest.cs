using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint3.Task3.V16.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint3.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValibGetCharCount()
        {
            DataService ds = new DataService();

            string value = "ice nice ice creamcc";
            char item = 'c';

            int res = ds.GetCharCount(value, item);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
