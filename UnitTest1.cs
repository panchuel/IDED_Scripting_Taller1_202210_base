using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        #region Stacks

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

        #endregion Stacks

        #region ServiceCenterStructures
        private List<Ticket> tickets = new List<Ticket> 
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

        Ticket[] paymentTickets = { };
        private Queue<Ticket> PaymentQueue;
        Ticket[] subscriptionTickets = { };
        private Queue<Ticket> subscriptionQueue;
        Ticket[] cancellationTickets = { };
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