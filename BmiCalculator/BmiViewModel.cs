using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculator
{
  public class BmiViewModel : INotifyPropertyChanged, IDataErrorInfo
  {
    public event PropertyChangedEventHandler PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName]string propertyName = "")
    {
      var propertyChanged = this.PropertyChanged;
      if (propertyChanged != null)
      {
        propertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    #region Height変更通知プロパティ
    private string _Height;

    public string Height
    {
      get
      { return _Height; }
      set
      {
        _Height = value;
        if (_Height == value)
          return;
        RaisePropertyChanged();
      }
    }
    #endregion


    #region Weight変更通知プロパティ
    private string _Weight;

    public string Weight
    {
      get
      { return _Weight; }
      set
      {
        if (_Weight == value)
          return;
        _Weight = value;
        RaisePropertyChanged();
      }
    }
    #endregion


    #region Bmi変更通知プロパティ
    private decimal? _Bmi;

    public decimal? Bmi
    {
      get
      { return _Bmi; }
      set
      {
        if (_Bmi == value)
          return;
        _Bmi = value;
        RaisePropertyChanged();

        if (_Bmi.HasValue)
        {
          if (_Bmi < 18.5m)
          {
            BmiBackColor = Color.LightBlue;
          }
          else if (25m <= _Bmi)
          {
            BmiBackColor = Color.OrangeRed;
          }
          else
          {
            BmiBackColor = SystemColors.Control;
          }
        }
        else
        {
          BmiBackColor = SystemColors.Control;
        }
      }
    }
    #endregion


    #region BmiBackColor変更通知プロパティ
    private Color _BmiBackColor;

    public Color BmiBackColor
    {
      get
      { return _BmiBackColor; }
      set
      {
        if (_BmiBackColor == value)
          return;
        _BmiBackColor = value;
        RaisePropertyChanged();
      }
    }
    #endregion

    public BmiViewModel()
    {
      Clear();
    }

    public void Clear()
    {
      this.Height = null;
      this.Weight = null;
      this.Bmi = null;
      this.errors.Clear();
    }

    private readonly IDictionary<string, string> errors = new Dictionary<string, string>();


    private void SetError(string error, [CallerMemberName]string propertyName = null)
    {
      errors[propertyName] = error;
    }


    public string Error
    {
      get { return null; }
    }

    public string this[string columnName]
    {
      get
      {
        if (errors.ContainsKey(columnName))
        {
          return errors[columnName];
        }
        else
        {
          return null;
        }
      }
    }

    public bool HasErrors
    {
      get
      {
        return errors.Count != 0 || !string.IsNullOrEmpty(Error);
      }
    }

    public void Validate()
    {
      errors.Clear();

      {
        string propertyName = "Height";
        if (String.IsNullOrEmpty(Height))
        {
          SetError("身長を入力してください。", propertyName);
        }
        else
        {
          decimal value;
          if (!decimal.TryParse(Height, out value))
          {
            SetError("身長には正の数値を入力してください。", propertyName);
          }

          if (value <= 0)
          {
            SetError("身長には正の数値を入力してください。", propertyName);
          }
        }
      }
      {
        string propertyName = "Weight";
        if (String.IsNullOrEmpty(Weight))
        {
          SetError("体重を入力してください。", propertyName);
        }
        else
        {
          decimal value;
          if (!decimal.TryParse(Weight, out value))
          {
            SetError("体重には正の数値を入力してください。", propertyName);
          }

          if (value <= 0)
          {
            SetError("体重には正の数値を入力してください。", propertyName);
          }
        }
      }
    }
  }
}
