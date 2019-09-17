namespace Characters.Common
{
  public class Initiate
  {
    private int _value;
    public int Value => _value;

    public Initiate(int value)
    {
      _value = value;
    }

    public override string ToString()
    {
      return $"{Value}";
    }
  }
}