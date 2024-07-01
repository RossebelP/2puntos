using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2puntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("1. notas , (2) pares e impares, 3.suma y resta, 4.salir ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        notas();
                        break;
                    case 2:
                        paresImpares();
                        break;
                    case 3:
                        sumaResta();
                        break;
                    case 4: Console.WriteLine("salir");
                        break;
                        default:
                        Console.WriteLine("opcion no valida");
                        break;
                }
            } while (op != 4);
        }
        static void notas() 
        {
            int filas = 10;
            int columnas = 3;
            int[,] notas = new int[filas, columnas];
            Random random = new Random();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    notas[i, j] = random.Next(0, 21);
                }
            }
            Console.WriteLine("Matriz de notas generada:");
            MostrarMatriz(notas);
            Console.WriteLine("\nPromedio por fila:");
            Fila(notas);
            Console.ReadLine();
        }
        static void MostrarMatriz(int[,] matriz)

        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Fila(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            for (int i = 0; i < filas; i++)
            {
                int suma = 0;
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
                double promedio = (double)suma / columnas;
                Console.WriteLine($"Fila {i + 1}: {promedio:F2}");
            }
        }
        static void paresImpares()
        {
            int[,] matriz = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = rnd.Next(0, 101);
                }
            }
            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("\t" + matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nNúmeros pares:");
            int conteoPares = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        Console.Write("\t" + matriz[i, j]);
                        conteoPares++;
                    }
                }
            }
            Console.WriteLine("\nCantidad de números pares: " + conteoPares);
            Console.WriteLine("\nNúmeros impares:");
            int conteoImpares = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] % 2 != 0)
                    {
                        Console.Write("\t" + matriz[i, j]);
                        conteoImpares++;
                    }
                }
            }
            Console.WriteLine("\nCantidad de números impares: " + conteoImpares);
            Console.ReadLine();
        }
        static void sumaResta() 
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];

            Console.WriteLine("Ingrese los valores de la matriz 1");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingrese el valor de la posición  [" + i + "," + j + "]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ingrese los valores de la matriz 2");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingrese el valor de la posición [" + i + "," + j + "]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz 1");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t"+matriz1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz 2");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t"+matriz2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Suma de las matrices");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t"+(matriz1[i, j] + matriz2[i, j] ));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Resta de las matrices");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t"+(matriz1[i, j] - matriz2[i, j]));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
