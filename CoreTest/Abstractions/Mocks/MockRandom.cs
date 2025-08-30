using EDaemon.Abstractions;

namespace EDaemonTest.Abstractions.Mocks
{
    public class MockRandom : IRandom
    {
        private readonly Queue<int> _values;

        public MockRandom(params int[] values)
        {
            _values = new Queue<int>(values);
        }

        public int Next(int minValue, int maxValue)
        {
            if (_values.Count == 0)
                throw new InvalidOperationException("No more mock values available");

            return _values.Dequeue();
        }
    }
}
