using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_Diagnostigo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chance");

            string numChance;
            int[] ints = new int[4];

            while (true)
            {
                Console.WriteLine("Inserte el número de 4 digitos con el que quiere hacer el chance: ");
                numChance = Console.ReadLine();
                
                if (numChance.Length == 4)
                {
                    char[] num = numChance.ToCharArray();

                    for (int i = 0; i < num.Length; i++)
                    {
                        // ints[i] = Convert.ToInt32(num[i]);
                        ints[i] = num[i] - '0';
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Marcación incorrecta");
                }
            }

            int[] baloto = new int[4];

            /* baloto[0] = 1;
            baloto[1] = 2;
            baloto[2] = 3;
            baloto[3] = 4; */
                    
            for (int i = 0; i < 4; i++)
            {
                Random random = new Random();
                baloto[i] = random.Next(1, 9);
            }

            Console.WriteLine($"El numero ganador es: {baloto[0]} {baloto[1]} {baloto[2]} {baloto[3]}");

            int cantidadApuesta;
            Console.WriteLine("Inserte la cantidad de dinero que quiere apostar: ");
            cantidadApuesta = Convert.ToInt32(Console.ReadLine());

            VerficarGanador(ints , baloto, cantidadApuesta);
        }

        static int premio;
        static int VerficarGanador(int [] ints, int [] baloto, int cantidadApuesta)
            {
                bool [] siEs = new bool[ints.Length];
                bool [] boolBaloto = new bool[baloto.Length];
                int contador = 0;
                int[] copiaJugador = new int[4];
                int[] copiaGanador = new int[4];

                for (int i = 0; i < baloto.Length; i++)
                {
                    boolBaloto[i] = true;
                }

                for (int i = 0; i < 4; i++)
                {
                   copiaJugador[i] = ints[i];
                   copiaGanador[i] = baloto[i];
                }

                Array.Sort(copiaJugador);
                Array.Sort(copiaGanador);

                bool mismosDigitos = true;

                for (int i = 0; i < 4; i++)
                {
                    if (copiaJugador[i] != copiaGanador[i])
                    {
                        mismosDigitos = false;
                        break;
                    }
                }

                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] == baloto[i])
                    {
                       siEs [i] = true;
                       contador++;
                       ints[i] = 10;

                    } else 
                    {
                        siEs[i] = false;
                    }
                }    

                for (int j = 0; j < ints.Length; j++)
                {
                    if (siEs[0] == true & siEs[1] == true & siEs[2] == true & siEs[3] == true)
                    {
                        premio = 4500 * cantidadApuesta;

                    } else if (siEs[1] == true & siEs[2] == true & siEs[3] == true)
                    {
                        premio = 400 * cantidadApuesta;
                    } else if (siEs[2] == true & siEs[3] == true)
                    {
                        premio = 50 * cantidadApuesta;
                    } else if (siEs[3] == true)
                    {
                        premio = 5 * cantidadApuesta;
                    }else if (contador != 4 & mismosDigitos)
                    {
                     premio = 200 * cantidadApuesta;
                    }
                    else
                    {
                        premio = 0;
                    }
                }

                Console.WriteLine("El premio del chance es: " + premio);

                return premio;
        }        
    }   
}
