using EDaemon.Abstractions;
using EDaemonTest.Abstractions.Mocks;

namespace EDaemonTest.Abstractions
{
    [TestFixture]
    public class RollTests
    {
        [TearDown]
        public void TearDown()
        {
            // Reset to default after each test
            Roll.ResetRandom();
        }

        #region D3 Roll Tests
        [Test]
        public void Roll_D3_WithNoParams_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(2);
            List<int> mockedDie = new List<int> { 2 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D3();

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(0));
            Assert.That(actual.Total, Is.EqualTo(2));
        }

        [Test]
        public void Roll_2D3_WithNoModifiers_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(1, 3);
            List<int> mockedDie = new List<int> { 1, 3 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D3(2);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(2));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(0));
            Assert.That(actual.Total, Is.EqualTo(4));
        }

        [Test]
        public void Roll_D3_WithPositiveModifier_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(2);
            List<int> mockedDie = new List<int> { 2 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D3(1, 3);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(3));
            Assert.That(actual.Total, Is.EqualTo(5));
        }

        [Test]
        public void Roll_D3_WithNegativeModifier_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(3);
            List<int> mockedDie = new List<int> { 3 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D3(1, -2);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(-2));
            Assert.That(actual.Total, Is.EqualTo(1));
        }

        [Test]
        public void Roll_D3_WithMultipleDiceAndModifiers_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(3, 1, 2);
            List<int> mockedDie = new List<int> { 3, 1, 2 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D3(3, 2);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(3));
            Assert.That(actual.DiceRollsResult.GetValue(0), Is.EqualTo(3));
            Assert.That(actual.DiceRollsResult.GetValue(1), Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult.GetValue(2), Is.EqualTo(2));
            Assert.That(actual.Modifier, Is.EqualTo(2));
            Assert.That(actual.Total, Is.EqualTo(8));
        }
        #endregion

        #region D6 Roll Tests
        [Test]
        public void Roll_D6_WithNoParams_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(5);
            List<int> mockedDie = new List<int> { 5 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D6();

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(0));
            Assert.That(actual.Total, Is.EqualTo(5));
        }

        [Test]
        public void Roll_2D6_WithNoModifiers_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(2, 4);
            List<int> mockedDie = new List<int> { 2, 4 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D6(2);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(2));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(0));
            Assert.That(actual.Total, Is.EqualTo(6));
        }

        [Test]
        public void Roll_D6_WithPositiveModifier_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(4);
            List<int> mockedDie = new List<int> { 4 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D6(1, 2);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(2));
            Assert.That(actual.Total, Is.EqualTo(6));
        }

        [Test]
        public void Roll_D6_WithNegativeModifier_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(6);
            List<int> mockedDie = new List<int> { 6 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D6(1, -3);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(-3));
            Assert.That(actual.Total, Is.EqualTo(3));
        }

        [Test]
        public void Roll_D6_WithMultipleDiceAndModifiers_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(1, 6, 3);
            List<int> mockedDie = new List<int> { 1, 6, 3 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D6(3, 1);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(3));
            Assert.That(actual.DiceRollsResult.GetValue(0), Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult.GetValue(1), Is.EqualTo(6));
            Assert.That(actual.DiceRollsResult.GetValue(2), Is.EqualTo(3));
            Assert.That(actual.Modifier, Is.EqualTo(1));
            Assert.That(actual.Total, Is.EqualTo(11));
        }
        #endregion

        #region D10 Roll Tests
        [Test]
        public void Roll_D10_WithNoParams_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(7);
            List<int> mockedDie = new List<int> { 7 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D10();

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(0));
            Assert.That(actual.Total, Is.EqualTo(7));
        }

        [Test]
        public void Roll_2D10_WithNoModifiers_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(3, 9);
            List<int> mockedDie = new List<int> { 3, 9 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D10(2);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(2));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(0));
            Assert.That(actual.Total, Is.EqualTo(12));
        }

        [Test]
        public void Roll_D10_WithPositiveModifier_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(8);
            List<int> mockedDie = new List<int> { 8 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D10(1, 4);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(4));
            Assert.That(actual.Total, Is.EqualTo(12));
        }

        [Test]
        public void Roll_D10_WithNegativeModifier_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(10);
            List<int> mockedDie = new List<int> { 10 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D10(1, -5);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(-5));
            Assert.That(actual.Total, Is.EqualTo(5));
        }

        [Test]
        public void Roll_D10_WithMultipleDiceAndModifiers_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(2, 10, 5);
            List<int> mockedDie = new List<int> { 2, 10, 5 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D10(3, 3);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(3));
            Assert.That(actual.DiceRollsResult.GetValue(0), Is.EqualTo(2));
            Assert.That(actual.DiceRollsResult.GetValue(1), Is.EqualTo(10));
            Assert.That(actual.DiceRollsResult.GetValue(2), Is.EqualTo(5));
            Assert.That(actual.Modifier, Is.EqualTo(3));
            Assert.That(actual.Total, Is.EqualTo(20));
        }
        #endregion

        #region D100 Roll Tests
        [Test]
        public void Roll_D100_WithNoParams_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(85);
            List<int> mockedDie = new List<int> { 85 };
            Roll.SetRandom(mockRandom);
            var actual = Roll.D100();
            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(0));
            Assert.That(actual.Total, Is.EqualTo(85));
        }

        [Test]
        public void Roll_2D100_WithNoModifiers_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(20, 75);
            List<int> mockedDie = new List<int> { 20, 75 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D100(2);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(2));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(0));
            Assert.That(actual.Total, Is.EqualTo(95));
        }

        [Test]
        public void Roll_D100_WithPositiveModifier_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(60);
            List<int> mockedDie = new List<int> { 60 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D100(1, 15);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(15));
            Assert.That(actual.Total, Is.EqualTo(75));
        }

        [Test]
        public void Roll_D100_WithNegativeModifier_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(90);
            List<int> mockedDie = new List<int> { 90 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D100(1, -20);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(1));
            Assert.That(actual.DiceRollsResult, Is.EquivalentTo(mockedDie));
            Assert.That(actual.Modifier, Is.EqualTo(-20));
            Assert.That(actual.Total, Is.EqualTo(70));
        }

        [Test]
        public void Roll_D100_WithMultipleDiceAndModifiers_ReturnsValidResult()
        {
            var mockRandom = new MockRandom(10, 55, 100);
            List<int> mockedDie = new List<int> { 10, 55, 100 };
            Roll.SetRandom(mockRandom);

            var actual = Roll.D100(3, 5);

            Assert.That(actual.DiceRollsResult.Length, Is.EqualTo(3));
            Assert.That(actual.DiceRollsResult.GetValue(0), Is.EqualTo(10));
            Assert.That(actual.DiceRollsResult.GetValue(1), Is.EqualTo(55));
            Assert.That(actual.DiceRollsResult.GetValue(2), Is.EqualTo(100));
            Assert.That(actual.Modifier, Is.EqualTo(5));
            Assert.That(actual.Total, Is.EqualTo(170));
        }
        #endregion
    }
}
