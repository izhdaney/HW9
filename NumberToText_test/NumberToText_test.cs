using NUnit.Framework;
using HW9;

namespace NumberToText_test
{
    public class Tests
    {
        private NumberToText _numb;

        [SetUp]
        public void Setup()
        {
            _numb = new NumberToText();
        }

        [TestCase(1, "one")]
        [TestCase(40, "forty")]
        [TestCase(54, "fifty-four")]
        [TestCase(100, "one hundred")]
        [TestCase(0, "zero")]
        [TestCase(101, "one hundred and one")]
        [TestCase(200, "two hundred")]
        [TestCase(113, "one hundred and thirteen")]
        [TestCase(13, "thirteen")]
        [TestCase(140, "one hundred and forty")]
        [TestCase(265, "two hundred and sixty-five")]
        [TestCase(999, "nine hundred and ninety-nine")]
        [TestCase(10, "ten")]
        [TestCase(7, "seven")]
        [TestCase(30, "thirty")]
        [TestCase(70, "seventy")]
        public void Test1(int number, string exp)
        {
            var res = _numb.getResultTask6(number);


            Assert.AreEqual(exp, res);
        }
    }
}