namespace Model.Characters.Common
{
  public class Threat
  {
    private int _value;
    public int Value => _value;

    public Threat(int value)
    {
      _value = value;
    }
  }
}