using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static int[] GetNextGreaterValue(Stack<int> sourceStack)
        {
            if (sourceStack == null)
            {
                return null;
            }

            int[] result = new int[sourceStack.Count];

            return result;
        }

        internal static Dictionary<int, EValueType> ClassifyNumbers(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;
            result.InitializeQueueCollection(3);

            return result;
        }

        internal static bool AddNewTicket(Ticket ticket, Queue<Ticket> targetQueue)
        {
            bool result = false;

            return result;
        }
    }
}