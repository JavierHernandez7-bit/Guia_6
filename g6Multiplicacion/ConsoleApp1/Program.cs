using System;

namespace ConsoleApp1
{//Javier Enrique Hernandez Marquez HM210444
    class Program
    {

        static void tablasDeMultiplicar(int n)
        {
            for (int i = 1; i < 11; i++)
                Console.WriteLine(i + " * " + n + "=" + i * n + "\n");
        }
        static void Main(string[] args)
        {
            int n;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("\nPor favor digite el numero del cual desea observar la tabla de multiplicacíon");
                n = int.Parse(Console.ReadLine());
                tablasDeMultiplicar(n);
            }
            Console.ReadKey();
        }
    }
}


