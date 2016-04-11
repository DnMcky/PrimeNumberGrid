using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication1
{
    public class PrimeGrid
    {
        public static void Main(string[] args)
        {
            PrimeGrid primeGrid = new PrimeGrid();
            int[] primes = primeGrid.PrimeFinder(5);
            Console.Write(primes[0]);
            Console.Write(primes[1]);
            Console.Write(primes[2]);
            Console.ReadKey();
        }

        public int[] PrimeFinder(int numberOfPrimesReq)
        {
            bool a = false;
            int i = 1;
            int j = 0;
            int[] primeArray = new int[numberOfPrimesReq];
            while (a == false) 
            {
                if (IsPrime(i).Equals(true))
                {
                    primeArray[j] = i;
                    j++;
                }
                
                if (j == numberOfPrimesReq)
                {
                    a = true;
                }
                i++;
            }
            return primeArray;
        }

        public bool IsPrime(int numberToCheck)
        {
            if (numberToCheck == 1) return false;
            if (numberToCheck == 2) return true;

            if (numberToCheck % 2 == 0) return false;

            for (int i = 3; i < numberToCheck; i += 2)
            {
                if (numberToCheck % i == 0) return false;
            }

            return true;
        }

        public int Multiply(int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}