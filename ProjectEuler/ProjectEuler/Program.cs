using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Program
    {
        public static int MultiplesOf3And5(int max, List<int> Multis)
        {
            int sum = 0;
            for (int i = 0; i < max; i++)
            {
                foreach (int multi in Multis)
                {
                    if (i % multi == 0) 
                    { 
                        sum += i;
                    }
                }
            }
            return sum;
        }

        public static int EvenFibonacciNumbers(int max)
        {
            int sum = 0;
            int fibminus1 = 1;
            int fibminus2 = 0;
            int fib = 1;

            while(fib < max)
            {
                fibminus2 = fibminus1;
                fibminus1 = fib;
                fib = fibminus1 + fibminus2;
                

                if (fib % 2 == 0)
                {
                    sum += fib;
                }
            }

            return sum;
        }

        //not my solution
        public static int LargestPrimeFactor(long number)
        {
            List<int> primeFactors = new List<int>();

            for (int factorIterator = 2; factorIterator <= number; factorIterator++)
            {
                bool isFactor = number % factorIterator == 0;
                bool isPrime = true;

                if(isFactor)
                {
                    for (int i = 2; i < factorIterator; i++)
                    {
                        if (factorIterator % i == 0)
                        {
                            isPrime = false;
                            continue;
                        }
                    }
                }

                if(isFactor && isPrime)
                {
                    primeFactors.Add(factorIterator);
                }
            }

            return primeFactors[primeFactors.Count - 1];
        }
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() { 3, 5 };
            //Console.WriteLine(MultiplesOf3And5(1000, numbers));

            //Console.WriteLine(EvenFibonacciNumbers(4000000));
            int blah = LargestPrimeFactor(600851475143);
            Console.WriteLine(blah);
        }
    }
}
