using System;

namespace EDaemon.Abstractions
{
    public static class Roll
    {
        private static IRandom _random = new SystemRandom();

        public static void SetRandom(IRandom random)
        {
            _random = random;
        }

        public static void ResetRandom()
        {
            _random = new SystemRandom();
        }

        public static RollResult D3(int quantity = 1, int modifier = 0)
        {
            return RollDices(3, quantity, modifier);
        }

        public static RollResult D6(int quantity = 1, int modifier = 0)
        {
            return RollDices(6, quantity, modifier);
        }

        public static RollResult D10(int quantity = 1, int modifier = 0)
        {
            return RollDices(10, quantity, modifier);
        }

        public static RollResult D100(int quantity = 1, int modifier = 0)
        {
            return RollDices(100, quantity, modifier);
        }

        private static RollResult RollDices(int sides, int quantity = 1, int modifier = 0)
        {
            if (sides <= 0)
                throw new ArgumentOutOfRangeException(nameof(sides), "Number of sides must be at least 1.");

            var dieResults = new int[quantity];
            int total = 0;

            for (int i = 0; i < quantity; i++)
            {
                dieResults[i] = _random.Next(1, sides + 1);
                total += dieResults[i];
            }

            return new RollResult
            {
                DiceRollsResult = dieResults,
                Modifier = modifier,
                Total = total + modifier
            };
        }
    }
}
