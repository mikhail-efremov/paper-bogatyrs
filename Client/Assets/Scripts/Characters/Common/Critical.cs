namespace Characters.Common
{
  public class Critical
  {
    private int _value;
    public int Value => _value;

    public Critical(int value)
    {
      _value = value;
    }

    public override string ToString()
    {
      return $"{Value}%";
    }
  }
}