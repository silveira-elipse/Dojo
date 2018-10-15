using System;

namespace ClassLibrary1
{
  public class FizzBuzz
  {
    public const string Fizz = "Fizz";
    public const string Buzz = "Buzz";
    public const string Fuzz = "FizzBuzz";

    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// </exception>
    /// <param name="i"></param>
    /// <returns></returns>
    public string CalcFizzBuzz(int i)
    {
      if (i < 1 || i > 100)
        throw new ArgumentOutOfRangeException("Input out of Bounds");

      if (i % 3 == 0 && i % 5 == 0)
        return Fuzz;

      if (i % 3 == 0)
        return Fizz;

      if (i % 5 == 0)
        return Buzz;

      return i.ToString();
    }
  }
}
