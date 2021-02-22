using System;

namespace Ejercicio5Guia6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("A continuacíon se mostrarán los números de 1 al 30, con excepcíon del número 25");

        
            for (int x = 1; x <25; x++)
            {
                Console.WriteLine(""+x+"");                            
            }
            for (int x = 26; x <= 100; x++)
            {

                Console.ReadKey();
            }

        }
    }
}
