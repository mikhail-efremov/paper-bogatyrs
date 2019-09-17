using Common;

namespace Characters.Common
{
  public class Damage
  {
    private Range<int> _value;
    public Range<int> Value => _value;

    public Damage(Range<int> value)
    {
      _value = value;
    }

    public override string ToString()
    {
      return $"{Value}";
    }
  }
}