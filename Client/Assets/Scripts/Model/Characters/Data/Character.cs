using System;
using Model.Battle;
using Model.Characters.Common;

namespace Model.Characters.Dto
{
  public class Character
  {
    public int MaxHealth { get; }
    public int CurrentHealth { get; private set; }

    public CharacterClass Class { get; }

    public Damage Damage { get; }

    public Threat Threat { get; }

    public Critical Critical { get; }

    public Initiate Initiate { get; }

    public Armor Armor { get; set; }

    public Character(int maxHealth)
    { 
      MaxHealth = maxHealth;
      CurrentHealth = MaxHealth;
    }

    public Character WithArmor(int points)
    {
      if (Armor == null)
        Armor = new Armor(points);
      else
        Armor.Points += points;
      
      return this;
    }

    public void Hit(HitInfo hit)
    {
      var points = hit.Points;
      
      var needLowerByArmor = points < 0 && Armor != null;
      if (needLowerByArmor)
        points = Math.Abs(points) / 2 < Armor.Points ? points / 2 : points + Armor.Points; 
      
      CurrentHealth += points;
    }
  }
}