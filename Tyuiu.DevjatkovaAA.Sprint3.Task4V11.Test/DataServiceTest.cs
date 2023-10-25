﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint3.Task4V11.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint3.Task4V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.840;

            Assert.AreEqual(wait, res);
        }
    }
}
