using System;

namespace MyFirstMethod
{
    /// <summary>
    /// O programa chama a função CountTo10, que por sua vez chama a função CountToN, que é usada 2 vezes e, com um input do user, conta até n (que é o input do user)
    /// </summary>
    class Program
    {
        /// <summary>
        /// Espera por um input do user e chama a função CountToN
        /// </summary>
        /// <param name="nCount">Input int do user</param>
        private static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            CountToN(nCount);

            for ( int num = 0; num < 2; num++ )
            {
                CountTo10();
            
            }

            
            

        }
        /// <summary>
        /// Invoca a função CountToN e conta até 10
        /// </summary>
        private static void CountTo10()
        {
            
             CountToN(10);
    

        }
        /// <summary>
        /// Faz um ciclo for na função CountToN e imprime até chegar a n
        /// </summary>
        /// <param name="n">Input do utilizador para limitar o ciclo</param>
        private static void CountToN (int n)
        {

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(i);


            }

        }

    }
}
