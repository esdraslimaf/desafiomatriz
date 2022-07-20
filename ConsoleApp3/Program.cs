using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre M e N para criamos a matriz com M linhas e N colunas: ");
            string[] mn = Console.ReadLine().Split(' ');

            int[,] mat = new int[int.Parse(mn[0]), int.Parse(mn[1])];

            // matriz criada acima MxN. Ler matriz abaixo:
            Console.WriteLine("");
            Console.WriteLine($"Insira os valores da matriz {mn[0]}x{mn[1]}");           

            for (int i = 0; i < int.Parse(mn[0]); i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < int.Parse(mn[1]); j++)
                {
                    mat[i, j] = int.Parse(values[j]);

                }
            }

            
            Console.WriteLine("");
            Console.WriteLine("Sua matriz é: ");
            Console.WriteLine("_______________");
            Console.WriteLine("");
            // Imprimir a matriz inteira: 
            for (int i = 0; i < int.Parse(mn[0]); i++)
            { //0,0 1,0 2,0 3,0... MUDA O X
                for (int j = 0; j < int.Parse(mn[1]); j++)
                { //0,0 0,1 0,2... 1,0 1,1 1,2 ... MUDA O Y
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("_______________");

            //Entre o número desejado para saber a localização dele dentro da matriz:
            Console.WriteLine("");

            Console.WriteLine("Insira o número que deseja saber a localização dentro da matriz: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < int.Parse(mn[0]); i++)
            {
                for (int j = 0; j < int.Parse(mn[1]); j++)
                {
                    if (mat[i, j] == numero)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < int.Parse(mn[0]) - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < int.Parse(mn[0]) - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);

                            /*numero que não tem nada na direita:
                            if (mat[i, j] == mat[i, int.Parse(mn[1])])
                            {
                                Console.WriteLine("Número não tem nada na direita");
                            }
                            else { Console.WriteLine("Right: "+ mat[i,j+1]); }*/
                        }

                    }

                }
            }
        }
    }
}


