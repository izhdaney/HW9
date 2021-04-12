using HW9;
using NUnit.Framework;
using System;

namespace MyArray_Test
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void DeleteElement_Test_1()
        {

            var test = new MyArray();

            int[] arr = { 1, 2, 6, 8 };

            var res = test.DeleteElemnt(arr);

            int[] exp = { 1, 2, 6 };


            Assert.AreEqual(exp, res);
        }

        [Test]
        public void DeleteElementOfIndex_Test_2()
        {

            var test = new MyArray();

            int[] arr = { 1, 2, 6, 8 };
            var index = 2;

            var res = test.DeleteElemntForIndex(arr, index);

            int[] exp = { 1, 2, 8 };

            Assert.AreEqual(exp, res);
        }

        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 0, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 1, new int[] { 0, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 2, new int[] { 0, 1, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 3, new int[] { 0, 1, 2, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 4, new int[] { 0, 1, 2, 3, 5, 6, 7, 8 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 5, new int[] { 0, 1, 2, 3, 4, 6, 7, 8 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 6, new int[] { 0, 1, 2, 3, 4, 5, 7, 8 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 7, new int[] { 0, 1, 2, 3, 4, 5, 6, 8 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 8, new int[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        public void DeleteElementOfIndex_Test_2(int[] arr, int index, int [] exp)
        {

            var test = new MyArray();

            var res = test.DeleteElemntForIndex(arr, index);

            Assert.AreEqual(exp, res);
        }


        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 7, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 7 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 789, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 789 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, -50, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, -50 })]
        public void InsertElement_Test_3(int[] arr, int insertValue, int[] exp)
        {

            var test = new MyArray();

            var res = test.InsertElement(arr, insertValue);

            Assert.AreEqual(exp, res);
        }

    }
}