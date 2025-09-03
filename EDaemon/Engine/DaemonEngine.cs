using EDaemon.Abstractions;
using EDaemon.Domain.Characters;
using EDaemon.Domain.System;
using EDaemon.Events;
using EDaemon.Rules;
using EDaemon.Rules.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EDaemon.Engine
{
    public class DaemonEngine : IDaemonEngine
    {
        private readonly IRuleEngine _ruleEngine;
        private readonly IEventBus _eventBus;
        private readonly IDiceRoller _roll;

        public DaemonEngine(
            IRuleEngine ruleEngine,
            IEventBus eventBus,
            IDiceRoller diceRoller)
        {
            _ruleEngine = ruleEngine;
            _eventBus = eventBus;
            _roll = diceRoller;

            InitializeDefaultRules();
        }

        public TestDetailedResult PerformBasicAttributeTest(Character character, string attribute, int? difficulty)
        {
            var roll = _roll.D100();

            var context = new TestContext
            {
                ActiveCharacter = character,
                ActiveSource = attribute,
                Difficulty = difficulty,
                BaseRoll = roll.Total
            };

            var ruleResult = _ruleEngine.ApplyRules(context);

            var testResult = CalculateTestResult(context, ruleResult);

            _eventBus.PublishAsync<TestResolvedEvent>(new TestResolvedEvent
            {
                Ids = new List<Guid> { character.Id },
                TestResult = testResult,
                EventType = "Basic Test",
                OccurredAt = DateTime.UtcNow,
            });

            return new TestDetailedResult {
                BaseRoll = roll.Total,
                Characters = new List<Character> { character },
                Difficulty = difficulty,
                TestResult = testResult
            };
        }

        #region Private methods
        private void InitializeDefaultRules()
        {
            // Register Daemon standard rules
            _ruleEngine.RegisterRule(new CriticalSuccessRule());
            // _ruleEngine.RegisterRule(new ArmorAbsorptionRule());
            // ... other rules
        }

        private TestResult CalculateTestResult(TestContext context, List<RuleResult>? ruleResults) {
            int totalModifier = 0;
            int totalScore = 1;
            List<RuleResult> appliedRules = new List<RuleResult>();

            if (ruleResults != null && ruleResults.Count > 0)
            {
                appliedRules = ruleResults.Where(mod => mod.Modifier.Key == "AttributeModifier").ToList();
                totalModifier = appliedRules.Sum(mod => mod.Modifier.Value);
            }
            
            var prop = context.ActiveCharacter.Attribute.GetType().GetProperty(context.ActiveSource);

            if (prop != null)
            {
                totalScore = (int)prop.GetValue(context.ActiveCharacter.Attribute) * 4;
            }

            return new TestResult
            {
                Success = context.BaseRoll <= totalScore + totalModifier - (context.Difficulty ?? 0),
                AppliedModifiers = appliedRules,
                ModTotal = totalModifier,
                TotalScore = totalScore,
            };
        }
        #endregion
    }
}
