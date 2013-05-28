using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BmiCalculator.Test
{
  [TestClass]
  public class CalculatorTest
  {
    [TestMethod]
    public void 身長100で体重が1なら1()
    {
      decimal height = 100;
      decimal weight = 1;
      decimal bmi = Calculator.CalculateBmi(height_cm: height, weight_kg: weight);

      Assert.AreEqual(1m, bmi);
    }
 
    [TestMethod]
    public void 身長が0ならエラー()
    {
      decimal height = 0;
      decimal weight = 1;
      try
      {
        Calculator.CalculateBmi(height_cm: height, weight_kg: weight);
        Assert.Fail();
      }
      catch (Exception ex)
      {
        Assert.IsInstanceOfType(ex, typeof(DivideByZeroException));
      }
    }
  }
}
