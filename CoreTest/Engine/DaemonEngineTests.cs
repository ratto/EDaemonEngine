using EDaemon.Abstractions;
using EDaemon.Domain.Characters;
using EDaemon.Domain.Items;
using EDaemon.Domain.System;
using EDaemon.Engine;
using EDaemon.Events;
using EDaemon.Rules;
using Moq;

namespace CoreTest.Engine
{
    [TestFixture]
    public class DaemonEngineTests
    {
        PlayerCharacter playerCharacter;

        [SetUp]
        public void Setup()
        {
            playerCharacter = new PlayerCharacter(
                "John Doe",
                42,
                new CharacterAttribute
                {
                    Strength = 17,
                    Agility = 14,
                    Dexterity = 15,
                    Constitution = 16,
                    Intelligence = 8,
                    WillPower = 10,
                    Perception = 12,
                    Charisma = 10
                },
                null,
                1,
                0,
                new List<Skill>(),
                new List<CombatSkill>(),
                new List<Enhancement>(),
                new List<Item>(),
                new List<Weapon>(),
                new List<ProtectiveItem>()
            );
        }

        [Test]
        public void PerformBasicAttributeTest_ShouldReturnExpectedResult()
        {
            // Arrange
            var mockRuleEngine = new Mock<IRuleEngine>();
            var mockEventBus = new Mock<IEventBus>();
            var mockDiceRoller = new Mock<IDiceRoller>();
            var character = playerCharacter;
            var attribute = "Strength";
            int? difficulty = 0;
            int baseRoll = 45;
            var testResult = new TestResult
            {
                Success = true,
                AppliedModifiers = new List<RuleResult>(),
                ModTotal = 0,
                TotalScore = 68 // 17 (attribute) * 4
            };
            mockDiceRoller.Setup(dr => dr.D100(1, 0)).Returns(new RollResult { Total = baseRoll });
            var sut = new DaemonEngine(mockRuleEngine.Object, mockEventBus.Object, mockDiceRoller.Object);

            // Act
            var result = sut.PerformBasicAttributeTest(character, attribute, difficulty);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.BaseRoll, Is.EqualTo(baseRoll));
            Assert.That(result.Difficulty, Is.EqualTo(difficulty));
            Assert.That(result.Characters.Count, Is.EqualTo(1));
            Assert.That(result.Characters[0].Id, Is.EqualTo(character.Id));
            Assert.That(result.TestResult.Success, Is.EqualTo(testResult.Success));
            Assert.That(result.TestResult.ModTotal, Is.EqualTo(testResult.ModTotal));
            Assert.That(result.TestResult.TotalScore, Is.EqualTo(testResult.TotalScore));
            mockEventBus.Verify(eb => eb.PublishAsync<TestResolvedEvent>(It.IsAny<TestResolvedEvent>()), Times.Once);
        }
    }
}
