using System;

namespace Common
{
  public class Range<T> where T : IComparable<T>
  {
    public T Minimum { get; set; }

    public T Maximum { get; set; }

    public override string ToString()
    {
      return $"{Minimum} - {Maximum}";
    }

    public bool IsValid()
    {
      return this.Minimum.CompareTo(Maximum) <= 0;
    }

    public bool ContainsValue(T value)
    {
      return Minimum.CompareTo(value) <= 0 && value.CompareTo(Maximum) <= 0;
    }

    public bool IsInsideRange(Range<T> range)
    {
      return IsValid() && range.IsValid() && range.ContainsValue(Minimum) && range.ContainsValue(Maximum);
    }

    public bool ContainsRange(Range<T> range)
    {
      return IsValid() && range.IsValid() && ContainsValue(range.Minimum) && ContainsValue(range.Maximum);
    }

    public Range(T minimum, T maximum)
    {
      Minimum = minimum;
      Maximum = maximum;
    }
  }
}