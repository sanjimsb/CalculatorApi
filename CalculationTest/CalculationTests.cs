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
    public void AddMethodShouldReturnDoubleWhenPassedTwoParameters(double left, double right, double expected)
    {
        double result = Calculate.Add(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -2, -4)]
    public void AddMethodShouldReturnNegativeDoubleWhenPassedTwoNegativeParameters(double left, double right, double expected)
    {
        double result = Calculate.Add(left, right);
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    [DataRow("2", "2")]
    public void AddMethodShouldReturnDoubleWhenPassedTwoStringAsParameter(double left, double right)
    {
        Assert.ThrowsException<ArgumentException>(() => Calculate.Add(left, right));
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
    public void SubtractionMethodShouldReturnDoubleWhenPassedTwoParameters(double left, double right, double expected)
    {
        double result = Calculate.Subtraction(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -2, 0)]
    public void SubtractionMethodShouldReturnDoubleWhenPassedTwoNegativeParameters(double left, double right, double expected)
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
    public void MultiplicationMethodShouldReturnDoubleWhenPassedTwoParameters(double left, double right, double expected)
    {
        double result = Calculate.Multiplication(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -2, 4)]
    public void MultiplicationMethodShouldReturnDoubleWhenPassedTwoNegativeParameters(double left, double right, double expected)
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
    public void DivisionMethodShouldReturnDoubleWhenPassedTwoParameters(double left, double right, double expected)
    {
        double result = Calculate.Division(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(-2, -2, 1)]
    public void DivisionMethodShouldReturnDoubleWhenPassedTwoNegativeParameters(double left, double right, double expected)
    {
        double result = Calculate.Division(left, right);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(5, 2, 2.5)]
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
}
