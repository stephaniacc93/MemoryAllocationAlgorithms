using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryAllocationAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos espacios de memorias quieres:");
            int spaces = int.Parse(Console.ReadLine());
            int[] memory = new int[spaces];
            int contador = 0;

            for (int i = 0; i < spaces; i++)
            {
                Console.WriteLine("De cuantos quieres el espacio {0}", i + 1);
                memory[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingresa el numero que desas checar si entra en la memoria:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecciona el algoritmo que deseas utilizar:\n1. First Fit\n2. Next Fit\n3. Best Fit\n4. Worst Fit\n5. Quick Fit");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    for (int i = 0; i < spaces; i++)
                    {
                        if (number <= memory[i])
                        {
                            Console.WriteLine("Cabe en el espacio de {0}", memory[i]);
                            contador = i;
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = contador; i < spaces; i++)
                    {
                        if (number <= memory[i])
                        {
                            Console.WriteLine("Cabe en el espacio de {0}", memory[i]);
                            contador = i;
                            break;
                        }
                        if (contador > spaces - 1)
                        {
                            contador = 0;
                        }
                    }
                    break;
                case 3:
                    Array.Sort(memory);
                    for (int i = 0; i < spaces; i++)
                    {
                        if (number <= memory[i])
                        {
                            Console.WriteLine("Cabe en el espacio de {0}", memory[i]);
                            contador = i;
                            break;
                        }
                    }
                    break;
                case 4:
                    memory = memory.OrderByDescending(i => i).ToArray();
                    for (int i = 0; i < spaces; i++)
                    {
                        if (number <= memory[i])
                        {
                            Console.WriteLine("Cabe en el espacio de {0}", memory[i]);
                            contador = i;
                            break;
                        }
                    }
                    break;
                case 5:
                    Array.Sort(memory);
                    int[] array1 = new int[spaces / 3];
                    int[] array2 = new int[spaces / 3];
                    int[] array3 = new int[spaces / 3];
                    int c = 0;
                    for (int i = 0; i < spaces / 3; i++)
                    {
                        array1[i] = memory[c];
                        c++;

                    }
                    for (int i = 0; i < spaces / 3; i++)
                    {

                        array2[i] = memory[c];
                        c++;
                    }
                    for (int i = 0; i < spaces / 3; i++)
                    {
                        array3[i] = memory[c];
                        c++;
                    }
                    if (number <= spaces / 3)
                    {
                        foreach (int i in array1)
                        {
                            if (number <= array1[0])
                            {
                                Console.WriteLine("Cabe en el espacio de {0} EN RANGO menor a {1}", array1[i], (spaces / 3));
                                Console.ReadLine();
                                contador = i;
                                break;
                            }
                            if (number <= array1[1])
                            {
                                Console.WriteLine("Cabe en el espacio de {0} EN RANGO menor a {1}", array1[i], (spaces / 3));
                                Console.ReadLine();
                                contador = i;
                                break;
                            }
                        }
                    }
                    else if (number <= (spaces / 3) * 2)
                    {
                        foreach (int i in array2)
                        {
                            if (number <= array2[0])
                            {
                                Console.WriteLine("Cabe en el espacio de {0} EN RANGO menor a {1}", array2[i], (spaces / 3) * 2);
                                Console.ReadLine();
                                contador = i;
                                break;
                            }
                            if (number <= array2[1])
                            {
                                Console.WriteLine("Cabe en el espacio de {0} EN RANGO menor a {1}", array2[i], (spaces / 3) * 2);
                                Console.ReadLine();
                                contador = i;
                                break;
                            }
                        }
                    }
                    else if (number <= (spaces / 3) * 3)
                    {
                        foreach (int i in array3)
                        {
                            if (number <= array3[0])
                            {
                                Console.WriteLine("Cabe en el espacio de {0} EN RANGO menor a {1}", array3[0], (spaces / 3) * 3);
                                Console.ReadLine();
                                contador = i;
                                break;
                            }
                            else if (number <= array3[1])
                            {
                                Console.WriteLine("Cabe en el espacio de {0} EN RANGO menor a {1}", array3[1], (spaces / 3) * 3);
                                Console.ReadLine();
                                contador = i;
                                break;
                            }
                        }
                    }
                    break;
            }

            Console.ReadLine();

        }
    }
}
