using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        #region IntStacks

        private Stack<int> testStackA;
        private Stack<int> testStackResultA;
        private int[] testStackElementsA = { 26, 3, 6, 5 };
        private int[] testStackResultElementsA = { -1, 6, -1, -1 };

        private Stack<int> testStackB;
        private Stack<int> testStackResultB;
        private int[] testStackElementsB = { 14, 8, 7, 13 };
        private int[] testStackResultElementsB = { -1, 13, 13, -1 };

        private Stack<int> testSortedStack;
        private Stack<int> testSortedStackResult;
        private int[] testSortedStackElements = { 20, 15, 4, 3 };
        private int[] testSortedStackResultElements = { -1, -1, -1, -1 };

        #endregion IntStacks

        private void PopulateTestNGVStacks()
        {
            testStackA.Populate(testStackElementsA);
            testStackResultA.Populate(testStackResultElementsA);
            testStackB.Populate(testStackElementsB);
            testStackResultA.Populate(testStackResultElementsB);
            testSortedStackResult.Populate(testSortedStackResultElements);
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

        /// <summary>
        /// Tests TestMethods.GetNextGreaterValue()
        /// </summary>
        [Test]
        public void TestGetNextGreaterValue()
        {
            Assert.AreEqual(testStackResultA, TestMethods.GetNextGreaterValue(testStackA));
            Assert.AreEqual(testStackResultB, TestMethods.GetNextGreaterValue(testStackB));
            Assert.AreEqual(testSortedStackResult, TestMethods.GetNextGreaterValue(testSortedStack));

            Assert.AreEqual(-1, TestMethods.GetNextGreaterValue(testStackA).Peek());
            Assert.AreEqual(-1, TestMethods.GetNextGreaterValue(testStackB).Peek());
        }

        /// <summary>
        /// Tests TestMethods.FillDictionaryFromSource
        /// </summary>
        [Test]
        public void TestFillDictionaryFromSource()
        {
        }

        /// <summary>
        /// Tests TestMethods.CountDictionaryRegistriesWithValueType
        /// </summary>
        [Test]
        public void TestCountDictionaryRegistriesWithValueType()
        { }

        /// <summary>
        /// Tests TestMethods.SortDictionaryRegistries
        /// </summary>
        [Test]
        public void TestSortDictionaryRegistries()
        { }

        /// <summary>
        /// Tests TestMethods.ClassifyTickets
        /// </summary>
        [Test]
        public void TestClassifyTickets()
        { }

        /// <summary>
        /// Tests TestMethods.AddNewTicket
        /// </summary>
        [Test]
        public void TestAddNewTicket()
        { }
    }
}