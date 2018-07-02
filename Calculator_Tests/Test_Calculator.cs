using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class Test_Calculator
    {
        [TestMethod]
        public void Test_Addition()
        {
            double lhs = 3.1;
            double rhs = 2.9;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Addition();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(6.0, result);
        }
        [TestMethod]
        public void Test_Addition_1()
        {
            Logic.Calculator Calc = new Logic.Calculator();
            Calc.Number_entered(1);
            Calc.Addition_entered();
            Calc.Number_entered(1);
            Calc.Addition_entered();
            Calc.Equals();
            string result = Calc.Equals();
            Assert.AreEqual("6", result);
        }
        [TestMethod]
        public void Test_Addition_2()
        {
            Logic.Calculator Calc = new Logic.Calculator();
            Calc.Number_entered(1);
            Calc.Addition_entered();
            Calc.Number_entered(1);
            Calc.Equals();
            string result = Calc.Equals();
            Assert.AreEqual("3", result);
        }
        [TestMethod]
        public void Multiple_Operators()
        {
            Logic.Calculator Calc = new Logic.Calculator();
            Calc.Number_entered(1);
            Calc.Addition_entered();
            Calc.Subtraction_entered();
            Calc.Number_entered(1);
            Calc.Equals();
            string result = Calc.Equals();
            Assert.AreEqual("-1", result);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            double lhs = 3.1;
            double rhs = 2.9;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Subtraction();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(0.2, result);
        }
        public void Test_Subtraction_1()
        {
            Logic.Calculator Calc = new Logic.Calculator();
            Calc.Number_entered(1);
            Calc.Subtraction_entered();
            Calc.Number_entered(1);
            string result = Calc.Equals();
            Assert.AreEqual("0", result);
        }
        [TestMethod]
        public void Test_Multiplication()
        {
            double lhs = 3.1;
            double rhs = 2.9;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Multiplication();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(8.99, result);
        }
        [TestMethod]
        public void Test_Divide()
        {
            double lhs = 3.0;
            double rhs = 1.5;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Division();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(2.0, result);
        }
        [TestMethod]
        public void Test_Divide_Zero()
        {
            double rhs = 0;
            double lhs = 10;
            Logic.Calculator Calc = new Logic.Calculator();
            Calc.Number_entered(lhs);
            Calc.Division_entered();
            string result = Calc.Number_entered(rhs);
            Assert.AreEqual("Invalid Input", result);
            Assert.AreEqual("Divide by Zero Error", result.ToString());
        }
        [TestMethod]
        public void Test_Reciprocal()
        {
            double lhs = 2;
            Logic_Interfaces.IUnaryOperation reciprocal = new Logic.Reciprocal();
            double result = reciprocal.Perform_unary_calculation(lhs);
            Assert.AreEqual(0.5, result);
        }
        public void Test_Reciprocal_1()
        {
            Logic.Calculator Calc = new Logic.Calculator();
            Calc.Number_entered(2);
            Calc.Reciprocal_entered();
            Calc.Reciprocal_entered();
            Calc.Reciprocal_entered();
            string result = Calc.Reciprocal_entered();
            Assert.AreEqual("2", result);
        }
        public void Test_Reciprocal_Zero()
        {
            double lhs = 0;
            Logic.Calculator Calc = new Logic.Calculator();
            Calc.Number_entered(lhs);
            string result = Calc.Square_root_entered();
            Assert.AreEqual("Divide by Zero Error", result.ToString());
        }
        [TestMethod]
        public void Test_SquareRoot()
        {
            double lhs = 4;
            Logic_Interfaces.IUnaryOperation sqt_root = new Logic.Square_root();
            double result = sqt_root.Perform_unary_calculation(lhs);
            Assert.AreEqual(2.0, result);
        }

        [TestMethod]
        public void Test_SquareRoot_Negative()
        {
            double lhs = -4;
            Logic.Calculator Calc = new Logic.Calculator();
            Calc.Number_entered(lhs);
            string result = Calc.Square_root_entered();
            Assert.AreEqual("Invalid Input", result);
        }

    }
}
