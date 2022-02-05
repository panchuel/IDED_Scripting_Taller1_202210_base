using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        #region IntStacks

        private Stack<int> testStackA;
        private int[] testStackElementsA = { 26, 3, 6, 5 };
        private int[] testStackResultA = { -1, 6, -1, -1 };

        private Stack<int> testStackB;
        private int[] testStackElementsB = { 14, 8, 7, 13 };
        private int[] testStackResultB = { -1, 13, 13, -1 };

        #endregion IntStacks

        #region Dictionaries
        #endregion

        private void PopulateTestNGVStacks()
        {
            testStackA.Populate(testStackElementsA);
            testStackB.Populate(testStackElementsB);
        }

        private void ClearNGVStacks()
        {
            testStackA.Clear();
            testStackB.Clear();
        }

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Reset()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestNGV()
        {
            Assert.AreEqual(testStackResultA, TestMethods.GetNextGreaterValue(testStackA));
            Assert.AreEqual(testStackResultB, TestMethods.GetNextGreaterValue(testStackB));
        }

        [Test]
        public void TestClassifyNumbers()
        { 
        }
    }
}