using System;

namespace MyFirstMethod
{
    class Program
    {
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
            
        private static void CountTo10()
        {
            
             CountToN(10);
    

        }

        private static void CountToN (int n)
        {

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(i);


            }

        }

    }
}
