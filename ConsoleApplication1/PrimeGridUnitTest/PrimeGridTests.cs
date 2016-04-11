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
            int numberOfPrimesReq = 5;
            int[] expected = new int[5] {2,3,5,7,11};
            int[] actual = target.PrimeFinder(numberOfPrimesReq);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);
            Assert.AreEqual(expected[4], actual[4]);
        }

        [TestMethod]
        public void TestIsPrime_EvenNumbersReturnFalse()
        {
            PrimeGrid target = new PrimeGrid();
            int numberToCheck = 4; //Using 4 as 2 is prime - create test to account for that next
            bool actual = target.IsPrime(numberToCheck);
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

        [TestMethod]
        public void TestIsPrime_OneReturnsFalse()
        {
            PrimeGrid target = new PrimeGrid();
            int numberToCheck = 1;
            Boolean actual = target.IsPrime(numberToCheck);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestIsPrime_SevenReturnsTrue()
        {
            PrimeGrid target = new PrimeGrid();
            int numberToCheck = 7;
            Boolean actual = target.IsPrime(numberToCheck);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestIsPrime_NinetySevenReturnsTrue()
        {
            PrimeGrid target = new PrimeGrid();
            int numberToCheck = 97;
            Boolean actual = target.IsPrime(numberToCheck);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestGridPrint_MultiplyReturnsCorrectAnswer()
        {
            PrimeGrid target = new PrimeGrid();
            int i = 3;
            int j = 97;
            int expected = 291;
            int actual = target.Multiply(i, j);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGridPrint_MultiplyUsingList()
        {
            PrimeGrid target = new PrimeGrid();
            int numberOfPrimesReq = 5;
            int[] list1 = target.PrimeFinder(numberOfPrimesReq);
            int[] list2 = list1;
            int expected = 33;
            int actual = target.Multiply(list1[1], list2[4]);
            Assert.AreEqual(expected, actual);
        }

    }
}
