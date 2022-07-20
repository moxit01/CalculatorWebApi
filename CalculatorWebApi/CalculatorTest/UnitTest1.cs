﻿namespace CalculatorTest;
using CalculatorLogic;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void AdditionUnitTestCheck1()
    {
        double num1 = 0;
        double num2 = 0;
        double desired = 0;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
    public void AdditionUnitTestCheck2()
    {
        double num1 = 7;
        double num2 = 3;
        double desired = 10;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
         public void AdditionUnitTestCheck3()
    {
        double num1 = 15;
        double num2 = 15;
        double desired = 30;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
    public void AdditionUnitTestCheck4()
    {
        double num1 = 25;
        double num2 = 11;
        double desired = 36;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
    public void AdditionUnitTestCheck5()
    {
        double num1 = 23;
        double num2 = 9;
        double desired = 32;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
    public void AdditionUnitTestCheck6()
    {
        double num1 = 17;
        double num2 = 21;
        double desired = 38;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
    public void AdditionUnitTestCheck7()
    {
        double num1 = 73;
        double num2 = 7;
        double desired = 80;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
    public void AdditionUnitTestCheck8()
    {
        double num1 = 72;
        double num2 = 3;
        double desired = 75;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
    public void AdditionUnitTestCheck9()
    {
        double num1 = 77;
        double num2 = 5;
        double desired = 82;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    [TestMethod]
    public void AdditionUnitTestCheck10()
    {
        double num1 = 188;
        double num2 = 11;
        double desired = 199;

        double actualResult = Logic.Addition(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }


    /// <summary>
    /// Subtraction Test
    /// </summary>

    [TestMethod]
    public void SubtractionUnitTestCheck1()
    {
        double num1 = 7;
        double num2 = 4;
        double desired = 3;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 2
    [TestMethod]
    public void SubtractionUnitTestCheck2()
    {
        double num1 = 11;
        double num2 = 3;
        double desired = 8;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 3
    [TestMethod]
    public void SubtractionUnitTestCheck3()
    {
        double num1 = 15;
        double num2 = 4;
        double desired = 11;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 4
    [TestMethod]
    public void SubtractionUnitTestCheck4()
    {
        double num1 = 23;
        double num2 = 11;
        double desired = 12;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 5
    [TestMethod]
    public void SubtractionUnitTestCheck5()
    {
        double num1 = 33;
        double num2 = 9;
        double desired = 24;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 6
    [TestMethod]
    public void SubtractionUnitTestCheck6()
    {
        double num1 = 17;
        double num2 = 11;
        double desired = 6;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 7
    [TestMethod]
    public void SubtractionUnitTestCheck7()
    {
        double num1 = 53;
        double num2 = 7;
        double desired = 46;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 8
    [TestMethod]
    public void SubtractionUnitTestCheck8()
    {
        double num1 = 61;
        double num2 = 3;
        double desired = 58;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 9
    [TestMethod]
    public void SubtractionUnitTestCheck9()
    {
        double num1 = 77;
        double num2 = 5;
        double desired = 72;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }

    //Test 10
    [TestMethod]
    public void SubtractionUnitTestCheck10()
    {
        double num1 = 88;
        double num2 = 11;
        double desired = 77;

        double actualResult = Logic.Subtraction(num1, num2);

        Assert.AreEqual(desired, actualResult);
    }




}
