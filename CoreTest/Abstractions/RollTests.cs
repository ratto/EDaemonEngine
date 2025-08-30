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
    }
}
