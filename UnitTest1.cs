using NUnit.Framework;
using System.Collections.Generic;
using static TestProject1.TestMethods;

namespace TestProject1
{
    public class Tests
    {
        #region Stacks

        private Stack<int> testStackA;
        private Stack<int> testStackResultA;
        private readonly int[] testStackElementsA = { 26, 3, 6, 5 };
        private readonly int[] testStackResultElementsA = { -1, 6, -1, -1 };

        private Stack<int> testStackB;
        private Stack<int> testStackResultB;
        private readonly int[] testStackElementsB = { 14, 8, 7, 13 };
        private readonly int[] testStackResultElementsB = { -1, 13, 13, -1 };

        private Stack<int> testSortedStack;
        private Stack<int> testSortedStackResult;
        private readonly int[] testSortedStackElements = { 20, 15, 4, 3 };
        private readonly int[] testSortedStackResultElements = { -1, -1, -1, -1 };

        #endregion Stacks

        #region ClassifiedDictionary

        private Dictionary<int, EValueType> testDict1;
        private Dictionary<int, EValueType> testDict2;
        private Dictionary<int, EValueType> testDict3;

        private Dictionary<int, EValueType> sortedTestDict1;
        private Dictionary<int, EValueType> sortedTestDict2;
        private Dictionary<int, EValueType> sortedTestDict3;

        private readonly int[] testDict1Elements = { 10, 4, 5, 3, 9, 34, 8, 13, 7 };
        private readonly int[] testDict2Elements = { 11, 23, 41, 61, 7, 20, 40, 99 };
        private readonly int[] testDict3Elements = { 30, 25, 45, 8, 56, 105, 1, 2 };

        private readonly Dictionary<int, EValueType> resultDict1 = new Dictionary<int, EValueType>()
        {
            { 10, EValueType.Two },
            { 4, EValueType.Two },
            { 5, EValueType.Five },
            { 3, EValueType.Three },
            { 9, EValueType.Three },
            { 34, EValueType.Two },
            { 8, EValueType.Two },
            { 13, EValueType.Prime },
            { 7, EValueType.Seven }
        };

        private readonly Dictionary<int, EValueType> resultDict2 = new Dictionary<int, EValueType>()
        {
            { 11, EValueType.Prime },
            { 23, EValueType.Prime },
            { 41, EValueType.Prime },
            { 61, EValueType.Prime },
            { 7, EValueType.Seven },
            { 20, EValueType.Two },
            { 40, EValueType.Two },
            { 99, EValueType.Three },
        };

        private readonly Dictionary<int, EValueType> resultDict3 = new Dictionary<int, EValueType>()
        {
            { 30, EValueType.Five },
            { 25, EValueType.Five },
            { 45, EValueType.Five },
            { 8, EValueType.Two },
            { 56, EValueType.Two },
            { 105, EValueType.Three },
            { 21, EValueType.Three },
            { 1, EValueType.Prime },
            { 2, EValueType.Two },
        };

        private readonly Dictionary<int, EValueType> sortedResultDict1 = new Dictionary<int, EValueType>()
        {
            { 10, EValueType.Two },
            { 4, EValueType.Two },
            { 5, EValueType.Five },
            { 3, EValueType.Three },
            { 9, EValueType.Three },
            { 34, EValueType.Two },
            { 8, EValueType.Two },
            { 13, EValueType.Prime },
            { 7, EValueType.Seven }
        };

        private readonly Dictionary<int, EValueType> sortedResultDict2 = new Dictionary<int, EValueType>()
        {
            { 11, EValueType.Prime },
            { 23, EValueType.Prime },
            { 41, EValueType.Prime },
            { 61, EValueType.Prime },
            { 7, EValueType.Seven },
            { 20, EValueType.Two },
            { 40, EValueType.Two },
            { 99, EValueType.Three },
        };

        private readonly Dictionary<int, EValueType> sortedResultDict3 = new Dictionary<int, EValueType>()
        {
            { 30, EValueType.Five },
            { 25, EValueType.Five },
            { 45, EValueType.Five },
            { 8, EValueType.Two },
            { 56, EValueType.Two },
            { 105, EValueType.Three },
            { 21, EValueType.Three },
            { 1, EValueType.Prime },
            { 2, EValueType.Two },
        };

        #endregion ClassifiedDictionary

        #region ServiceCenterStructures

        private List<Ticket> testTicketElements = new List<Ticket>
        {
            new Ticket(Ticket.ERequestType.Payment, 30),
            new Ticket(Ticket.ERequestType.Cancellation, 24),
            new Ticket(Ticket.ERequestType.Cancellation, 50),
            new Ticket(Ticket.ERequestType.Subscription, 99),
            new Ticket(Ticket.ERequestType.Payment, 31),
            new Ticket(Ticket.ERequestType.Subscription, 30),
            new Ticket(Ticket.ERequestType.Payment, 80),
            new Ticket(Ticket.ERequestType.Cancellation, 1),
            new Ticket(Ticket.ERequestType.Subscription, 30),
            new Ticket(Ticket.ERequestType.Cancellation, 80),
            new Ticket(Ticket.ERequestType.Payment, 10),
            new Ticket(Ticket.ERequestType.Payment, 6),
            new Ticket(Ticket.ERequestType.Cancellation, 39),
            new Ticket(Ticket.ERequestType.Subscription, 95),
            new Ticket(Ticket.ERequestType.Subscription, 43),
            new Ticket(Ticket.ERequestType.Cancellation, 70),
            new Ticket(Ticket.ERequestType.Payment, 15),
            new Ticket(Ticket.ERequestType.Payment, 41),
            new Ticket(Ticket.ERequestType.Subscription, 66),
            new Ticket(Ticket.ERequestType.Cancellation, 3),
        };

        private Ticket[] paymentTickets = { };
        private Queue<Ticket> PaymentQueue;
        private Ticket[] subscriptionTickets = { };
        private Queue<Ticket> subscriptionQueue;
        private Ticket[] cancellationTickets = { };
        private Queue<Ticket> cancellationQueue;

        #endregion ServiceCenterStructures

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

        private void PopulateTicketCollections()
        {
            PaymentQueue.Populate(paymentTickets);
            subscriptionQueue.Populate(subscriptionTickets);
            cancellationQueue.Populate(cancellationTickets);
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
            // Tests dictionaries are filled as expected.
            Assert.AreEqual(testDict1, resultDict1);
            Assert.AreEqual(testDict2, resultDict2);
            Assert.AreEqual(testDict3, resultDict3);

            // Tests dictionary keys are associated with the correct value
            Assert.IsTrue(testDict1.GetValueOrDefault(13) == EValueType.Prime);
            Assert.IsTrue(testDict1.GetValueOrDefault(10) == EValueType.Two);
            Assert.IsTrue(testDict1.GetValueOrDefault(7) == EValueType.Seven);

            Assert.IsTrue(testDict2.GetValueOrDefault(61) == EValueType.Prime);
            Assert.IsTrue(testDict2.GetValueOrDefault(99) == EValueType.Three);
            Assert.IsFalse(testDict2.GetValueOrDefault(20) == EValueType.Five);

            Assert.IsFalse(testDict3.GetValueOrDefault(21) == EValueType.Seven);
            Assert.IsFalse(testDict3.GetValueOrDefault(105) == EValueType.Five);
            Assert.IsTrue(testDict3.GetValueOrDefault(1) == EValueType.Prime);
        }

        /// <summary>
        /// Tests TestMethods.CountDictionaryRegistriesWithValueType
        /// </summary>
        [Test]
        public void TestCountDictionaryRegistriesWithValueType()
        {
            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict1, EValueType.Two), 4);
            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict1, EValueType.Five), 1);
            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict1, EValueType.Three), 2);

            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict2, EValueType.Five), 0);
            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict2, EValueType.Seven), 1);
            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict2, EValueType.Prime), 4);

            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict1, EValueType.Five), 3);
            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict1, EValueType.Two), 3);
            Assert.AreEqual(CountDictionaryRegistriesWithValueType(testDict1, EValueType.Three), 2);
        }

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