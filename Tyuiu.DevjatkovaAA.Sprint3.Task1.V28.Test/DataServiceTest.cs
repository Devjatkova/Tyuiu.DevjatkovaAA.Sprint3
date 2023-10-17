using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint3.Task1.V28.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 18;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = -0.186;

            Assert.AreEqual(wait, res);
        }
    }
}
