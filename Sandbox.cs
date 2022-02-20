using System;
using System.Collections;
using System.Collections.Generic;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            Stack<int> entrada = new Stack<int>();
            entrada.Push(14);
            entrada.Push(8);
            entrada.Push(7);
            entrada.Push(13);

            /*int[] stackToArray = entrada.ToArray();
            Stack<int> copyEntrada = new Stack<int>();

            for (int i = stackToArray.Length - 1; i >= 0; i--)
            {
                copyEntrada.Push(stackToArray[i]);
            }

            Stack<int> salida = new Stack<int>();
            List<int> salidas = new List<int>();
            List<int> toSort = new List<int>();

            while (copyEntrada.Count > 0)
            {
                int actual = copyEntrada.Pop();

                salidas.Add(actual);

                int valorMayor = actual;

                for (int i = 0; i < salidas.Count; i++)
                {
                    if(salidas[i] > valorMayor) valorMayor = salidas[i];
                }

                if(valorMayor == actual) toSort.Add(-1);
                else toSort.Add(valorMayor);
            }

            for (int i = toSort.Count-1; i >= 0; i--)
			{
                salida.Push(toSort[i]);
			}

            while(salida.Count > 0)
            {
                Console.WriteLine(salida.Pop());
            }*/
            
            int[] copiaEntrada = new int[entrada.Count];
            entrada.CopyTo(copiaEntrada, 0);
            Stack<int> salida = new Stack<int>();
            List<int> salidas = new List<int>();
            List<int> toSort = new List<int>();
 
            int valorMayor = 0, valorActual = 0;
            
            while(copiaEntrada.Length > 0)
            {
                for (int i = 0; i < copiaEntrada.Length; i++)
                {

                    valorActual = copiaEntrada[i];
                    valorMayor = valorActual;
                    for (int j = i; j < copiaEntrada.Length; j++)
                    {
                        if (valorActual < copiaEntrada[j])
                        {
                            valorMayor = copiaEntrada[j];
                        }
                    }
                    if (valorMayor == valorActual)
                    {
                        salida.Push(-1);
                    }
                    else
                    {
                        salida.Push(valorMayor);
                    }
                }
            }
            
            while(salida.Count > 0)
            {
                Console.WriteLine(salida.Pop());
            }
        }
    }
}