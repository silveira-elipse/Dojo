using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    private FizzBuzz m_fizzbuzz;

    [TestInitialize]
    public void Initial()
    {
      m_fizzbuzz = new FizzBuzz();
    }

    [TestMethod]
    public void PrintInputsString()
    {
      int[] values = { 1, 4, 7, 11, 98 };
      foreach (var t in values)
        Assert.AreEqual(t.ToString(), m_fizzbuzz.CalcFizzBuzz(t));
    }

    [TestMethod]
    public void PrintInputsOutOfBounds()
    {
      int[] values = { -1, 0, 107 };
      foreach (var t in values)
      {
        try
        {
          m_fizzbuzz.CalcFizzBuzz(t);
          Assert.Fail();
        }
        catch (ArgumentOutOfRangeException)
        {

        }
      }
    }

    [TestMethod]
    public void PrintInputsFizz()
    {
      int[] values = { 3, 6, 33, 18, 54, 78, 96 };
      foreach (var t in values)
        Assert.AreEqual(FizzBuzz.Fizz, m_fizzbuzz.CalcFizzBuzz(t));
    }

    [TestMethod]
    public void PrintInputsBuzz()
    {
      int[] values = { 5, 10, 55, 65, 85, 100};
      foreach (var t in values)
        Assert.AreEqual(FizzBuzz.Buzz, m_fizzbuzz.CalcFizzBuzz(t));
    }

    [TestMethod]
    public void PrintInputsFizzBuzz()
    {
      int[] values = { 15, 30, 45, 60, 75, 90 };
      foreach (var t in values)
        Assert.AreEqual(FizzBuzz.Fuzz, m_fizzbuzz.CalcFizzBuzz(t));
    }
  }
}
