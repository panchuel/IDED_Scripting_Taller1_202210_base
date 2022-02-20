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

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            int[] stackToArray = new int[sourceStack.Count];
            sourceStack.CopyTo(stackToArray, 0);                                                        //Convierte el source en un arreglo para poder hacerle una copia profunda
            Stack<int> copySource = new Stack<int>();                                                   //Pila donde se guarda la copia de source

            
            for (int i = stackToArray.Length - 1; i >= 0; i--)                                          //Organiza de nuevo la pila, que se desordenó al convertirla en un arreglo
            {
                copySource.Push(stackToArray[i]);
            }

            Stack<int> result = new Stack<int>();                                                       
            List<int> salidas = new List<int>();                                                        //Donde se guardan los datos que salen de la copia de Source
            List<int> toSort = new List<int>();                                                         //Se guardan los resultados para ordenarlos al final y que respete el orden del
            int max = copySource.Count;

            for (int i = 0; i < max; i++)
            {
                int actual = copySource.Pop();

                salidas.Add(actual);                                                                    //El dato que salga de la copia del source se añade a la lista

                int valorMayor = actual;                                                                //Se toma el valor actual como el valor mayor

                for (int j = 0; j < salidas.Count; j++)
                {
                    if (salidas[j] > valorMayor) valorMayor = salidas[j];                               //Se revisan los demas elementos que han salido de la copia del source para ver si hay uno mayor que el guardado anteriormente
                }

                if (valorMayor == actual) toSort.Add(-1);
                else toSort.Add(valorMayor);
            }

            for (int i = toSort.Count - 1; i >= 0; i--)                                                 //Se recorre de forma inversa para ordenarlos y dejarlos equivalentes a la copia de la pila
            {
                result.Push(toSort[i]);
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}