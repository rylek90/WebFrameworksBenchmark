
using System;
using System.Collections.Generic;

namespace aspnetcore.benchmark.Core
{
    public interface IGenerateNumbers
    {
        IReadOnlyCollection<int> Generate(int count, int max);
    }

    internal class NumbersGenerator : IGenerateNumbers
    {
        public IReadOnlyCollection<int> Generate(int count, int max)
        {
            var rand = new Random();
            var result = new List<int>();

            for (var i = 0; i < count; i += 1)
            {
                var randomNumber = rand.Next() % max;
                result.Add(randomNumber);
            }

            return result;
        }
    }
}