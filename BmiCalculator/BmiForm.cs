using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BmiCalculator
{
  public partial class BmiForm : Form
  {
    private readonly BmiViewModel vm = new BmiViewModel();

    public BmiForm()
    {
      InitializeComponent();

      this.bmiViewModelBindingSource.DataSource = vm;

      foreach (var ctrl in this.Controls.OfType<TextBox>())
      {
        this.errorProvider1.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleLeft);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        vm.Validate();
        if (vm.HasErrors)
        {
          return;
        }

        var height_cm = Calculator.Round(Decimal.Parse(vm.Height), 1);
        var weight_kg = Calculator.Round(Decimal.Parse(vm.Weight), 1);

        vm.Height = height_cm.ToString("0.0");
        vm.Weight = weight_kg.ToString("0.0");

        var bmi = Calculator.CalculateBmi(height_cm, weight_kg);

        vm.Bmi = Calculator.Round(bmi, 2);
      }
      finally
      {
        errorProvider1.UpdateBinding();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      vm.Clear();
      errorProvider1.UpdateBinding();
    }
  }
}
