using System;

namespace EDaemon.Abstractions
{
    public class SystemRandom : IRandom
    {
        private readonly Random _random = new Random();

        public int Next(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
    }
}
