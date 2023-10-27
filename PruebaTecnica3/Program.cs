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

            //Relleno matriz de "O"
            for (int i = 0; i < 4; i++)//Filas
            {
                for (int j = 0; j < 4; j++)//Columnas
                {
                    Matriz[i, j] = "O";
                }
            }

            for (int i = 0; i < myArray.Length; i += 2) //Tomo numeros de dos en dos
            {
                int PrimerNumero = myArray[i]; //Primer numero del grupo
                int SegundoNumero = myArray[i + 1]; //Segundo numero del grupo

                int NuevaPosicionX = PosicionX + PrimerNumero; //Cambio posicion para X

                if (NuevaPosicionX >= 0 && NuevaPosicionX <= 3) //Valido si la nueva posicion de X supera 4 casillas
                {
                    PosicionX = NuevaPosicionX;
                }
                else if (NuevaPosicionX > 3)
                {
                    PosicionX = 3;
                }
                else
                {
                    PosicionX = 0;
                }

                int NuevaPosicionY = PosicionY + SegundoNumero; //Cambio posicion para Y

                if (NuevaPosicionY >= 0 && NuevaPosicionY <= 3) //Valido si la nueva posicion de Y supera 4 casillas
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

            Matriz[PosicionY, PosicionX] = "X"; //Asigno la X a la matriz según la nueva posicion.

            for (int i = 0; i < 4; i++) //Recorro matriz para imprimirla
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
