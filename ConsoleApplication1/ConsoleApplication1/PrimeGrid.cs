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
            Console.WriteLine("Enter the number of primes you want to see in each axis of the grid: ");
            string input = Console.ReadLine();
            int intInput;
            Int32.TryParse(input, out intInput);
            int[] primes = primeGrid.PrimeFinder(intInput+1);
            primeGrid.PrintGrid(primes);
            Console.ReadKey();
        }

        public int[] PrimeFinder(int numberOfPrimesReq)
        {
            bool a = false;
            int i = 1;
            int j = 1;
            int[] primeArray = new int[numberOfPrimesReq];
            primeArray[0] = 1;
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

            int i = 0;
            foreach (var prime in listOne)
            {
                foreach (var prime2 in listTwo)
                {
                    if (i > 0)
                    {
                        int answer = Multiply(prime, prime2);
                        Console.Write(answer + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                        i++;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}