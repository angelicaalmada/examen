using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class ejercicio
    {
       
        public void vendedor()
        {
            int[,] arreglo = new int[,] { { 500, 1000, 250, 400, 60 }, { 3000, 150, 1800, 130, 20 }, { 100, 200, 2900, 90, 4000 }, { 400, 500, 300, 2400, 3600 } };
            int suma = 0;
            int totalProducto = 0;
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                suma = suma + arreglo[i, x];

                Console.WriteLine($"El vendedor {i} tubo una ganancia de ");


                for (int x = 0; x < arreglo.GetLength(1); x++)
                {

                    suma = suma + arreglo[i, x];
                    Console.WriteLine($"El vendedor {i} tubo una ganancia de {x}");

                }

            }

        }
        public void curp()
        {
            string[] arreglo = new string[18];
            for (int i = 0; i < arreglo.Length; i++)
            {
                if()
            }
              
        }

        public void RAND()
        {
            int[] array = new int[100];
            Random rnd = new Random();


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 1000);
            }

            Console.WriteLine("lista desordenada");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int temporal = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temporal = array[i];
                        array[i] = array[j];
                        array[j] = temporal;
                    }
                }
            }
            Console.WriteLine("lista ordenada");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.ReadLine();
        }


    }
}
