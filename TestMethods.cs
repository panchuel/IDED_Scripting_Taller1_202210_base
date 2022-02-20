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
            int[] copia = new int[sourceStack.Count];
            sourceStack.CopyTo(copia, 0);                                                        //Convierte el source en un arreglo para poder hacerle una copia profunda
            Stack<int> copySource = new Stack<int>();                                            //Pila donde se guarda la copia de source

            
            for (int i = copia.Length - 1; i >= 0; i--)                                          //Organiza de nuevo la pila, que se desordenó al convertirla en un arreglo
            {
                copySource.Push(copia[i]);
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
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();                     //Diccionario que pide el problema

            int[] copia = new int[sourceArr.Length];                                                    //Copia profunda del source
            sourceArr.CopyTo(copia, 0);


            for (int i = 0; i < copia.Length; i++)
            {
                if (copia[i] % 2 == 0 ) result.Add(copia[i], EValueType.Two);                           //Revisar si es Par
                else if (copia[i] % 3 == 0) result.Add(copia[i], EValueType.Three);                     //Revisar si es Multiplo de 3
                else if (copia[i] % 5 == 0) result.Add(copia[i], EValueType.Five);                      //Revisar si es Multiplo de 5
                else if (copia[i] % 7 == 0) result.Add(copia[i], EValueType.Seven);                     //Revisar si es Multiplo de 7 
                else result.Add(copia[i], EValueType.Prime);                                            //Revisar si es Primo
            }

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
            Queue<Ticket>[] result = new Queue<Ticket>[3];                                              // Los 3 arreglos que piden devolver en el problema

            Ticket[] copia = new Ticket[sourceList.Count];                                              //Copia profunda de la lista fuente
            sourceList.CopyTo(copia, 0);

            Queue<Ticket> pago = new Queue<Ticket>(), suscripcion = new Queue<Ticket>(), cancelacion = new Queue<Ticket>();
            int turnoSiguiente = 0;

            for (int i = 0; i < copia.Length; i++)                                                      //Se ordenan los turnos usando Bubble Sort (porque es el unico que se usar)
            {
                for (int j = 0; j < copia.Length - 1; j++)
                {
                    turnoSiguiente = copia[j + 1].Turn;
                    Ticket siguiente = copia[j + 1];

                    if (copia[j].Turn > turnoSiguiente)
                    {
                        copia[j + 1] = copia[j];
                        copia[j] = siguiente;
                    }
                }
            }

            for (int i = 0; i < copia.Length; i++)                                                      //Se asignan los turnos a las colas correspondientes
            {
                if (copia[i].RequestType == Ticket.ERequestType.Payment) pago.Enqueue(copia[i]);
                else if (copia[i].RequestType == Ticket.ERequestType.Subscription) suscripcion.Enqueue(copia[i]);
                else cancelacion.Enqueue(copia[i]);
            }

            result[0] = pago;
            result[1] = suscripcion;
            result[2] = cancelacion;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            Ticket.ERequestType tipoCola = targetQueue.Peek().RequestType;                              //Se revisa el elemento de RequestType de quien se quiere añadir el ticket y si coinside con alguno de los tipos que hay en tipoCola
            if(ticket.RequestType == tipoCola)
            {
                if (ticket.Turn > 0 && ticket.Turn < 100) result = true;
                else result = false;
            }

            return result;
        }        
    }
}