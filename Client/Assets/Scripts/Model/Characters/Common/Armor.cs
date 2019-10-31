namespace Model.Characters.Common
{
  public class Armor
  {
    public int Points { get; set; }

    public Armor(int points)
    {
      Points = points;
    }

    public override string ToString()
    {
      return $"{Points}";
    }
  }
}