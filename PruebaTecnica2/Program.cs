using System;

namespace PruebaTecnica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 1, 2, 3, 2, 7, 0, 1, 2, 3, 2, 7, 0 };

            for (int i = 0; i < arreglo.Length; i++)//primer numero a sumar
            {
                for (int j = i + 1; j < arreglo.Length; j++)//segundo numero a sumar
                {
                    if (arreglo[i] + arreglo[j] == 10)//comparo valor
                    {
                        Console.WriteLine(arreglo[i] + " " + arreglo[j]);//imprimo si el resultado coincide
                    }
                }
            }
        }
    }
}
