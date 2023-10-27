using System;

namespace PruebaTecnica3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, -1, 1, 0, 1, 2, -1, -1, -2 };
            string[,] Matriz = new string[4, 4];
            int PosicionX = 0;
            int PosicionY = 0;

            for (int i = 0; i < 4; i++)//Filas
            {
                for (int j = 0; j < 4; j++)//Columnas
                {
                    Matriz[i, j] = "O";
                }
            }

            for (int i = 0; i < myArray.Length; i += 2)
            {
                int PrimerNumero = myArray[i];
                int SegundoNumero = myArray[i + 1];

                int NuevaPosicionX = PosicionX + PrimerNumero;

                if (NuevaPosicionX >= 0 && NuevaPosicionX <= 3)
                {
                    PosicionX = NuevaPosicionX;
                }
                else if(NuevaPosicionX>3)
                {
                    PosicionX = 3;
                }
                else
                {
                    PosicionX = 0;
                }

                int NuevaPosicionY = PosicionY + SegundoNumero;


                if (NuevaPosicionY >= 0 && NuevaPosicionY <= 3)
                {
                    PosicionY = NuevaPosicionY;
                }
                else if (NuevaPosicionY > 3)
                {
                    PosicionY = 3;
                }
                else
                {
                    PosicionY = 0;
                }
            }



            Matriz[PosicionY, PosicionX] = "X";

            // Imprime el tablero
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
