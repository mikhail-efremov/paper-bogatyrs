namespace Model.Characters.Common
{
  public class Initiate
  {
    public int Value { get; }

    public Initiate(int value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return $"{Value}";
    }
  }
}