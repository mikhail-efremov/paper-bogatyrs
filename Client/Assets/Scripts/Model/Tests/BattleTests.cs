using Model.Battle;
using Model.Characters.Dto;
using NUnit.Framework;

namespace Model.Tests
{
  public class BattleTests
  {
    [TestCase(100, 50, ExpectedResult = 50)]
    [TestCase(500, 300, ExpectedResult = 200)]
    public int WhenHit_Character_CorrectHIt(int health, int damage)
    {
      var char2 = new Character(health);
      
      char2.Hit(new HitInfo().WithDamage(damage));

      return char2.CurrentHealth;
    }
    
    [TestCase(100, 50, 50, ExpectedResult = 75)]
    [TestCase(500, 50, 300, ExpectedResult = 250)]
    public int WhenHit_CharacterWithArmor_CorrectHIt(int health, int armor, int damage)
    {
      var char2 = new Character(health).WithArmor(armor);
      
      char2.Hit(new HitInfo().WithDamage(damage));

      return char2.CurrentHealth;
    }
  }
}