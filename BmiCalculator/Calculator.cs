using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculator
{
  public static class Calculator
  {
    public static decimal CalculateBmi(decimal height_cm, decimal weight_kg)
    {
      var height_m = height_cm / 100;
      var bmi = weight_kg / (height_m * height_m);
      return bmi;
    }

    public static decimal Round(decimal value, int size = 0)
    {
      decimal multiplicant = (decimal)Math.Pow(10, size);
      decimal multiplied = value * multiplicant;
      int uppered = (int)(multiplied + 0.5m);
      decimal rounded = (decimal)uppered / multiplicant;
      return rounded;
    }
  }
}
