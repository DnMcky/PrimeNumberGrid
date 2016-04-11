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
            return i*j;
        }

        public void PrintGrid(int[] listOfPrimes)
        {
            int[] listOne = listOfPrimes;
            int[] listTwo = listOfPrimes;
            Console.Write("/t");
            foreach (var prime in listOne)
            {
                foreach (var prime2 in listTwo)
                {
                    int answer = Multiply(prime, prime2);
                    Console.Write(answer + "/t");
                }
                Console.Write("/n");
            }
        }
    }
}