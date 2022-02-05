using System.Collections.Generic;

namespace TestProject1
{
    internal static class TestUtils
    {
        internal static void Populate<T>(this Stack<T> stack, T[] elements)
        {
            if (stack == null)
            {
                stack = new Stack<T>();
            }

            for (int i = 0; i < elements.Length; i++)
            {
                stack.Push(elements[i]);
            }
        }

        internal static void Populate<T1, T2>(this IDictionary<T1, T2> dict, T1[] keys, T2[] values)
        {
            if (keys == null || values == null || keys.Length != values.Length)
            {
                return;
            }

            for (int i = 0; i <= keys.Length; i++)
            {
                dict.TryAdd(keys[i], values[i]);
            }
        }

        internal static void Populate<T>(this Queue<T> queue, T[] elements)
        {
            if (queue == null)
            {
                queue = new Queue<T>();
            }

            for (int i = 0; i < elements.Length; i++)
            {
                queue.Enqueue(elements[i]);
            }
        }

        internal static void InitializeQueueCollection<T>(this Queue<T>[] collection, int lenght)
        {
            if (collection == null)
            {
                collection = new Queue<T>[lenght];
            }

            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = new Queue<T>();
            }
        }
    }
}