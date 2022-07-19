using System.Reflection;
using Calculation;


namespace CalculationTest;

[TestClass]
public class CalculationTests
{
    //Test methods for Addition
    [TestMethod]
    public void AdditionMethodShouldExistxs()
    {
        MethodInfo info = typeof(Calculate).GetMethod("Add");
        Assert.IsNotNull(info);
    }

    [TestMethod]
    [DataRow(2,2,4)]
    [DataRow(8,9,17)]
    public void AddMethodShouldReturnDoubleWhenPassedTwoArguments(double left, double right, double expected)
    {
        double result = Calculate.Add(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -2, -4)]
    [DataRow(-5, -10, -15)]
    [DataRow(-90, -10, -100)]
    public void AddMethodShouldReturnNegativeDoubleWhenPassedTwoNegativeArguments(double left, double right, double expected)
    {
        double result = Calculate.Add(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(2, -8, -6)]
    [DataRow(-10, 8, -2)]
    [DataRow(100, -8, 92)]
    public void AddMethodVerfyingWhenOneArgumentIsNegative(double left, double right, double expected)
    {
        double result = Calculate.Add(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(0, 0, 0)]
    public void AddMethodShouldReturnZeroWhenTwoZeroArePassedAsArguments(double left, double right, double expected)
    {
        double result = Calculate.Add(left, right);
        Assert.AreEqual(expected, result);
    }



    //Test methods for Subtraction
    [TestMethod]
    public void SubtractionMethodShouldExists()
    {
        MethodInfo info = typeof(Calculate).GetMethod("Subtraction");
        Assert.IsNotNull(info);
    }

    [TestMethod]
    [DataRow(2, 2, 0)]
    [DataRow(8, 2, 6)]
    public void SubtractionMethodShouldReturnDoubleWhenPassedTwoArguments(double left, double right, double expected)
    {
        double result = Calculate.Subtraction(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -2, 0)]
    [DataRow(-18, -12, -6)]
    public void SubtractionMethodShouldReturnDoubleWhenPassedTwoNegativeArguments(double left, double right, double expected)
    {
        double result = Calculate.Subtraction(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(2, 8, -6)]
    [DataRow(12, 8, 4)]
    public void SubtractionMethodVerfyingWhenOneArgumentIsNegative(double left, double right, double expected)
    {
        double result = Calculate.Subtraction(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(2.5, 8.25, -5.75)]
    [DataRow(120.45, -8.32, 128.77)]
    public void SubtractionMethodVerfyingDecimalArgument(double left, double right, double expected)
    {
        double result = Calculate.Subtraction(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(0, 0, 0)]
    public void SubtractionMethodShouldReturnZeroWhenTwoZeroArePassedAsArgument(double left, double right, double expected)
    {
        double result = Calculate.Subtraction(left, right);
        Assert.AreEqual(expected, result);
    }



    //Test methods for Multiplication
    [TestMethod]
    public void MultiplicationMethodShouldExists()
    {
        MethodInfo info = typeof(Calculate).GetMethod("Multiplication");
        Assert.IsNotNull(info);
    }

    [TestMethod]
    [DataRow(2, 2, 4)]
    [DataRow(0, 0, 0)]
    public void MultiplicationMethodShouldReturnDoubleWhenPassedTwoArguments(double left, double right, double expected)
    {
        double result = Calculate.Multiplication(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -2, 4)]
    [DataRow(-9, -6, 54)]
    public void MultiplicationMethodShouldReturnDoubleWhenPassedTwoNegativeArguments(double left, double right, double expected)
    {
        double result = Calculate.Multiplication(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, 5, -10)]
    [DataRow(-2, -5, 10)]
    public void MultiplicationMethodShouldReturnNegativeDoubleWhenPassedOneNegativeArgument(double left, double right, double expected)
    {
        double result = Calculate.Multiplication(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, 0, 0)]
    public void MultiplicationMethodShouldReturnZeroWhenPassedOneArgumentAsZero(double left, double right, double expected)
    {
        double result = Calculate.Multiplication(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(2.5, 3.5, 8.75)]
    [DataRow(1.5, 3.5, 5.25)]
    public void MultiplicationMethodVerifyingResultOfDecimalArgument(double left, double right, double expected)
    {
        double result = Calculate.Multiplication(left, right);
        Assert.AreEqual(expected, result);
    }



    //Test methods for Division
    [TestMethod]
    public void DivisionMethodShouldExists()
    {
        MethodInfo info = typeof(Calculate).GetMethod("Division");
        Assert.IsNotNull(info);
    }

    [TestMethod]
    [DataRow(2, 2, 1)]
    public void DivisionMethodShouldReturnDoubleWhenPassedTwoArguments(double left, double right, double expected)
    {
        double result = Calculate.Division(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(2, -2, -1)]
    public void DivisionMethodShouldReturnNegativeDoubleIfOneArgumentIsNegative(double left, double right, double expected)
    {
        double result = Calculate.Division(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -2, 1)]
    public void DivisionMethodShouldReturnDoubleWhenPassedTwoNegativeArguments(double left, double right, double expected)
    {
        double result = Calculate.Division(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(5, 2, 2.5)]
    [DataRow(9, 100, 0.09)]
    public void DivisionMethodShouldReturnDecimalDouble(double left, double right, double expected)
    {
        double result = Calculate.Division(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(0, 0)]
    public void DivisionMethodShouldReturnExceptionWhenDivideByZero(double left, double right)
    {
        double result = Calculate.Division(left, right);
        Assert.IsTrue(double.IsNaN(result));
    }

    [TestMethod]
    [DataRow(7, 0)]
    public void DivisionMethodShouldReturnInifiniteWhenDividedByZero(double left, double right)
    {
        double result = Calculate.Division(left, right);
        Assert.IsTrue(double.IsInfinity(result));
    }

    [TestMethod]
    [DataRow(0, 7, 0)]
    [DataRow(0, -9, 0)]
    public void DivisionMethodShouldReturnZeroWhenDividedZeroByAnyOtherNumber(double left, double right, double expected)
    {
        double result = Calculate.Division(left, right);
        Assert.AreEqual(expected, result);
    }
}
