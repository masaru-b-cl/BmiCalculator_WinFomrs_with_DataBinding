using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BmiCalculator.Test
{
  [TestClass]
  public class BmiViewModelTest
  {
    private BmiViewModel vm = null;
    [TestInitialize]
    public void SetUp()
    {
      vm = new BmiViewModel();
    }

    [TestMethod]
    public void 身長が未入力ならエラー()
    {
      // Arrange
      vm.Height = null;

      // Act
      vm.Validate();

      // Assert
      Assert.AreEqual("身長を入力してください。", vm["Height"]);
    }

    [TestMethod]
    public void 身長が数値でないならエラー()
    {
      // Arrange
      vm.Height = "1e10";

      // Act
      vm.Validate();

      // Assert
      Assert.AreEqual("身長には正の数値を入力してください。", vm["Height"]);
    }

    [TestMethod]
    public void 身長が正の数値でないならエラー()
    {
      // Arrange
      vm.Height = "0";

      // Act
      vm.Validate();

      // Assert
      Assert.AreEqual("身長には正の数値を入力してください。", vm["Height"]);
    }

    [TestMethod]
    public void 身長が正の数値ならエラーなし()
    {
      // Arrange
      vm.Height = "1.1";

      // Act
      vm.Validate();

      // Assert
      Assert.IsNull(vm["Height"]);
    }

    [TestMethod]
    public void 体重が未入力ならエラー()
    {
      // Arrange
      vm.Weight = null;

      // Act
      vm.Validate();

      // Assert
      Assert.AreEqual("体重を入力してください。", vm["Weight"]);
    }

    [TestMethod]
    public void 体重が数値でないならエラー()
    {
      // Arrange
      vm.Weight = "1e10";

      // Act
      vm.Validate();

      // Assert
      Assert.AreEqual("体重には正の数値を入力してください。", vm["Weight"]);
    }

    [TestMethod]
    public void 体重が正の数値でないならエラー()
    {
      // Arrange
      vm.Weight = "0";

      // Act
      vm.Validate();

      // Assert
      Assert.AreEqual("体重には正の数値を入力してください。", vm["Weight"]);
    }

    [TestMethod]
    public void 体重が正の数値ならエラーなし()
    {
      // Arrange
      vm.Weight = "1.1";

      // Act
      vm.Validate();

      // Assert
      Assert.IsNull(vm["Weight"]);
    }
  }
}
