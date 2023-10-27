using System;

namespace PruebaTecnica
{
    class Program
    {
        static void Main(string[] args)
        {

            string negro = "X";
            string blanco = "_";
            string ficha = "negro";
            int n = 7;
            string nUsuario = "";

            Console.WriteLine("Introduzca un numero de 1 a 10: ");
            nUsuario = Console.ReadLine();

            try
            {
                n = Int32.Parse(nUsuario);
            }
            catch
            {
                Console.WriteLine("El valor ingresado no es valido.");
            }

            if (n < 1 || n > 10)
            {
                Console.WriteLine("El valor ingresado no se encuentra entre 1 y 10, por defecto 7.");
                n = 7;
            }

            for (int i = 0; i < n; i++)//filas
            {
                for (int j = 0; j < n; j++)//columnas
                {
                    if (ficha == "negro")
                    {
                        Console.Write(negro);
                        ficha = "blanco";
                    }
                    else
                    {
                        Console.Write(blanco);
                        ficha = "negro";
                    }
                }
                Console.WriteLine("");
            }


        }
    }
}
