using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new[] { 1, 3, -2, 4 };

            double[] y = new[] { 1.1, -2.5, 4.3 };

            double[,] a = new[,] { 
                { -1.1, 2.1, 3.1 },
                { 2.1, 1.1, 3.1 } 
            };

            int[][] b = new[] {
                new [] { 1, 2, 3 },
                new [] { 1 },
                new [] { 1, 2, 3, 4 }
            };


            Console.WriteLine("Arreglo x:\n");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("[" + i + "]:\t" + x[i]);
            }

            Console.WriteLine("\n\nArreglo y:");
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("[" + i + "]:\t" + y[i]);
            }
            
            Console.WriteLine("\n\nArreglo a:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("[" + i + ", " + j + "]:\t" + a[i, j]);
                }
            }
            
            Console.WriteLine("\n\nArreglo b:");
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.WriteLine("[" + i + "][" + j + "]:\t" + b[i][j]);
                }
                Console.WriteLine("");
            }

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }
    }
}
