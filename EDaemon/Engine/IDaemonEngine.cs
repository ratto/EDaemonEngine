using EDaemon.Domain.Characters;
using EDaemon.Domain.Enums;
using EDaemon.Domain.System;
using EDaemon.Events;

namespace EDaemon.Engine
{
    public interface IDaemonEngine
    {
        // Basic Tests
        TestDetailedResult PerformBasicAttributeTest(Character character, string attributeString, int? difficulty);
        // TestResult PerformTest(Character character, string skillName, int difficulty);
        // TestResult PerformOpposedTest(Character character1, string skill1, Character character2, string skill2);

        // Combat System
        // CombatResult ResolveCombat(Character attacker, Character defender, Weapon weapon);
        // InitiativeResult RollInitiative(IEnumerable<Character> characters);

        // Campaign Management
        // Character CreateCharacter(CharacterTemplate template);
        // void ApplyExperience(Character character, int experience);
        // void LevelUpCharacter(Character character);

        // Configuration
        // void ConfigureRules(Action<IRuleEngine> configuration);
    }
}
