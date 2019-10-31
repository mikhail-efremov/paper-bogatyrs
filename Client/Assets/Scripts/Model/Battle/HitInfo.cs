namespace Model.Battle
{
  public class HitInfo
  {
    public int Points { get; set; }

    public HitInfo WithDamage(int points)
    {
      Points -= points;
      return this;
    }

    public HitInfo WithHeal(int points)
    {
      Points += points;
      return this;
    }
  }
}