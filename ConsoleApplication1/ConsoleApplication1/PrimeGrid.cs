using System;

namespace ConsoleApplication1
{
    public class PrimeGrid
    {
        static void Main(string[] args)
        {
            
        }

        public Array PrimeFinder(int numbeOfPrimesReq)
        {
            throw new NotImplementedException();
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
    }
}