using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace PrimeGridUnitTest
{
    [TestClass]
    public class PrimeGridTests
    {
        [TestMethod]
        public void TestPrimeFinder_ReturnsCorrectNoOfPrimes()
        {
            PrimeGrid target = new PrimeGrid();
            int numbeOfPrimesReq = 5;
            int expected = 5;
            Array primeArray = target.PrimeFinder(numbeOfPrimesReq);
            int actual = primeArray.Length;
            Assert.AreEqual(expected, actual);
        }
    }
}
