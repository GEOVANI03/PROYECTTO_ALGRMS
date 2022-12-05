using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ALG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL PROGRAMA");
            int opcion = 0;
            while (opcion != 7)
            {
                Console.WriteLine("\n1. Invertir la posicion de los valores de un vector");
                Console.WriteLine("2. Averiguar si una lista de numeros esta ordenada de menor a mayor");
                Console.WriteLine("3. Averiguar si una lista de numeros esta ordenada de manera estrictamente creciente");
                Console.WriteLine("4. Averiguar si una lista de numeros tiene numeros repetidos");
                Console.WriteLine("5. Ordenar una lista de numeros de menor a mayor");
                Console.WriteLine("6. Buscar si esta un numero en especifico de una lista de numeros");
                Console.WriteLine("7. Hallar el promedio de un vector de numeros");
              
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Invertir();
                            break;
                        case 2:
                            Ordenado();
                            break;
                        case 3:
                            OrdenadoEstricto();
                            break;
                        case 4:
                            Repetidos();
                            break;
                        case 5:
                            Ordenar();
                            break;
                        case 6:
                            Buscar();
                            break;
                        case 7:
                            Promedio();
                            break;
                        
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
            Console.ReadKey();

            static void Invertir()
            {
                try
                {
                    Console.WriteLine("Ingrese el tamaño del vector");
                    int tam = Convert.ToInt32(Console.ReadLine());
                    int[] vector = new int[tam];
                    for (int G = 0; G < tam; G++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        vector[G] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("El vector original es: ");
                    for (int R = 0; R < tam; R++)
                    {
                        Console.Write(vector[R] + " ");
                    }
                    Console.WriteLine("El vector invertido es: ");
                    for (int J = tam - 1; J >= 0; J--)
                    {
                        Console.Write(vector[J] + " ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            static void Ordenado()
            {
                try
                {
                    Console.WriteLine("inbtrodusca el tamaño de la lista");
                    int tam = Convert.ToInt32(Console.ReadLine());
                    int[] vector = new int[tam];
                    for (int M = 0;Mi < tam; M++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        vector[M] = Convert.ToInt32(Console.ReadLine());
                    }
                    int cont = 0;
                    for (int M = 0; M < tam - 1; M++)
                    {
                        if (vector[M] <= vector[M + 1])
                        {
                            cont++;
                        }
                    }
                    Console.WriteLine("La lista de numeros ingresada es: ");
                    for (int M = 0; M < tam; M++)
                    {
                        Console.Write(vector[i] + " ");
                    }
                    if (cont == tam - 1)
                    {
                        Console.WriteLine(" esta ordenado de menor a mayor");
                    }
                    else
                    {
                        Console.WriteLine("no esta ordenado de menor a mayor");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            static void OrdenadoEstricto()
            {
                try
                {
                    Console.WriteLine("Ingrese el tamaño de la lista");
                    int tam = Convert.ToInt32(Console.ReadLine());
                    int[] vector = new int[tam];
                    for (int R = 0; R < tam; R++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        vector[R] = Convert.ToInt32(Console.ReadLine());
                    }
                    int cont = 0;
                    for (int R = 0; R < tam - 1; i++)
                    {
                        if (vector[R] < vector[R + 1])
                        {
                            cont++;
                        }
                    }
                    Console.WriteLine("La lista de numeros ingresada es: ");
                    for (int R = 0; R < tam; R++)
                    {
                        Console.Write(vector[i] + " ");
                    }
                    if (cont == tam - 1)
                    {
                        Console.WriteLine(" esta ordenado de manera estrictamente creciente");
                    }
                    else
                    {
                        Console.WriteLine(" no esta ordenado de manera estrictamente creciente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            static void Repetido()
            {
                try
                {
                    Console.WriteLine("Ingrese el tamaño de la lista");
                    int tam = Convert.ToInt32(Console.ReadLine());
                    int[] vector = new int[tam];
                    for (int E = 0; E < tam; E++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        vector[E] = Convert.ToInt32(Console.ReadLine());
                    }
                    int cont = 0;
                    for (int E = 0; E < tam - E; i++)
                    {
                        for (int G = R + 1; G < tam; G++)
                        {
                            if (vector[R] == vector[j])
                            {
                                cont++;
                            }
                        }
                    }
                    Console.WriteLine("La lista de numeros ingresada es: ");
                    for (int R = 0; R < tam; R++)
                    {
                        Console.Write(vector[R] + " ");
                    }
                    if (cont > 0)
                    {
                        Console.WriteLine("\nLa lista tiene numeros repetidos,los cuales son: ");
                        for (int R = 0; R < tam - 1; R++)
                        {
                            for (int G = R + 1; G < tam; G++)
                            {
                                if (vector[R] == vector[R])
                                {
                                    Console.Write(vector[R] + " ");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(" no tiene numeros repetidos");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            static void Ordenar()
            {
                try
                {
                    Console.WriteLine("Ingrese el tamaño de la lista");
                    int tam = Convert.ToInt32(Console.ReadLine());
                    int[] vector = new int[tam];
                    for (int G = 0; G < tam; G++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        vector[G] = Convert.ToInt32(Console.ReadLine());
                    }
                    int aux;
                    for (int R = 0; R < tam - 1; R++)
                    {
                        for (int G = R + 1; G < tam; G++)
                        {
                            if (vector[R] > vector[G])
                            {
                                aux = vector[R];
                                vector[R] = vector[j];
                                vector[G] = aux;
                            }
                        }
                    }
                    Console.WriteLine("La lista ordenada de menor a mayor es: ");
                    for (int H = 0; H < tam; H++)
                    {
                        Console.Write(vector[H] + " ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            static void Buscar()
            {
                try
                {
                    Console.WriteLine("Ingrese el tamaño de la lista");
                    int tam = Convert.ToInt32(Console.ReadLine());
                    int[] vector = new int[tam];
                    for (int D = 0; D < tam; D++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        vector[D] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el numero que busca");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int cont = 0;
                    for (int F = 0; F < tam; F++)
                    {
                        if (vector[F] == num)
                        {
                            cont++;
                        }
                    }
                    Console.WriteLine("La lista de numeros es: ");
                    for (int F = 0; F < tam; F++)
                    {
                        Console.Write(vector[i] + " ");
                    }
                    if (cont > 0)
                    {
                        Console.WriteLine("El numero " + num + " si se encuentra en la lista y se repite " + cont + " veces");
                    }
                    else
                    {
                        Console.WriteLine("El numero " + num + " no se encuentra en la lista");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            static void Promedio()
            {
                try
                {
                    Console.WriteLine("Ingrese el tamaño del vector");
                    int tam = Convert.ToInt32(Console.ReadLine());
                    int[] vector = new int[tam];
                    for (int R = 0; R < tam; R++)
                    {
                        Console.WriteLine("Ingrese un numero");
                        vector[R] = Convert.ToInt32(Console.ReadLine());
                    }
                    int suma = 0;
                    for (int R = 0; R < tam; R++)
                    {
                        suma = suma + vector[i];
                    }
                    int promedio = suma / tam;
                    Console.WriteLine("La lista de numeros ingresada es: ");
                    for (int R = 0; R < tam; R++)
                    {
                        Console.Write(vector[i] + " ");
                    }
                    Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}
