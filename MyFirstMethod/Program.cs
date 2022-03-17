using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int num = 0; num < 2; num++ )
            CountTo10();
        }


        private static void CountTo10()
        {

            for(int i = 1; i <= 10; i++)
            {

                Console.WriteLine(i);

            }

        }

    }
}
