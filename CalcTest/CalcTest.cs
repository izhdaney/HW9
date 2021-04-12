using HW9;
using NUnit.Framework;
using System;

namespace CalcTest
{
    public class Tests
    {
        private Calc _calclogic;

        [SetUp]
        public void Setup()
        {
            _calclogic = new Calc();
        }

        [TestCase(1, 0, 1)]
        [TestCase(0, 1, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 2, 5)]
        [TestCase(-5, -5, -10)]
        [TestCase(-8, 2, -6)]
        [TestCase(7, -2, 5)]
        [TestCase(9, 0.5, 9.5)]
        [TestCase(0.5, 10, 10.5)]
        [TestCase(0.74, 0.0004, 0.7404)]
        [TestCase(1.698, 0.1, 1.798)]
        public void SumTest(double number1, double number2, double exp)
        {

            var res = _calclogic.GetSum(number1, number2);

            Assert.AreEqual(exp, res);
        }

        [TestCase(1, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(5, 5, 25)]
        [TestCase(6, 48, 288)]
        [TestCase(1.45, 1.69, 2.4505)]
        [TestCase(10, 54, 540)]
        [TestCase(100, 08, 800)]
        [TestCase(09, 10, 90)]
        [TestCase(-8, 64, -512)]
        [TestCase(2, -4, -8)]
        [TestCase(-2, -2, 4)]
        [TestCase(0, -9, 0)]
        public void MultTest(double number1, double number2, double exp)
        {

            var res = _calclogic.GetMult(number1, number2);

            Assert.AreEqual(exp, res);
        }


        [TestCase(1, 0, 1)]
        [TestCase(0, 1, -1)]
        [TestCase(5, 5, 0)]
        [TestCase(6, 48, -42)]
        [TestCase(1.45, 1.69, -0.24)]
        [TestCase(10, 54, -44)]
        [TestCase(100, 08, 92)]
        [TestCase(0, 0, 0)]
        [TestCase(-8, 64, -72)]
        [TestCase(2, -4, 6)]
        [TestCase(-2, -2, 0)]
        [TestCase(0, -9, 9)]
        public void SubTest(double number1, double number2, double exp)
        {

            var res = _calclogic.GetSub(number1, number2);

            Assert.AreEqual(exp, res);
        }

        [Test]
        public void DivTest_Erorr_1()
        {

            Assert.Throws<DivideByZeroException>(() =>
            {
                var res = _calclogic.GetDiv(5, 0);
            });
        }

        [TestCase(4, 2, 2)]
        [TestCase(0, 4, 0)]
        [TestCase(5, 5, 1)]
        [TestCase(6, 48, 0.125)]
        [TestCase(1.45, 1.69, 0.857)]
        [TestCase(10, 54, 0.185)]
        [TestCase(100, 08, 12.5)]
        [TestCase(0, -3, 0)]
        [TestCase(-8, 64, -0.125)]
        [TestCase(2, -4, -0.5)]
        [TestCase(-2, -2, 1)]
        [TestCase(50, 10, 5)]
        public void DivTest(double number1, double number2, double exp)
        {

            var res = _calclogic.GetDiv(number1, number2);

            Assert.AreEqual(exp, res, 0.001);
        }



    }
}