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

        [TestMethod]
        public void TestIsPrime_EvenNumbersReturnFalse()
        {
            PrimeGrid target = new PrimeGrid();
            int numberToCheck = 4; //Using 4 as 2 is prime - create test to account for that next
            Boolean actual = target.IsPrime(numberToCheck);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestIsPrime_TwoReturnsTrue()
        {
            PrimeGrid target = new PrimeGrid();
            int numberToCheck = 2; 
            Boolean actual = target.IsPrime(numberToCheck);
            Assert.IsTrue(actual);
        }
    }
}
