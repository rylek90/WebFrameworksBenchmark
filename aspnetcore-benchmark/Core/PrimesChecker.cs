
using System;
using System.Collections.Generic;
using System.Linq;
using aspnetcore.benchmark.Model;

namespace aspnetcore.benchmark.Core
{
    public interface ICheckPrimes
    {
        IEnumerable<PrimeModel> Check();
    }

    internal class PrimesChecker : ICheckPrimes
    {
        private readonly IGenerateNumbers _generator;
        public PrimesChecker(IGenerateNumbers generator)
        {
            _generator = generator;
        }
        public IEnumerable<PrimeModel> Check()
        {
            var numbers = _generator.Generate(100, 1000);
            return numbers.Select(n => new PrimeModel
            {
                val = n,
                isPrime = IsPrime(n)
            });
        }

        private static bool IsPrime(int number)
        {
            if (number == 2 || number == 3)
            {
                return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            var i = 5;
            var w = 2;

            while (i * i <= number)
            {
                if (number % i == 0)
                {
                    return false;
                }

                i += w;
                w = 6 - w;
            }

            return true;
        }
    }
}