using System;

namespace ExercicioMatrizes {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o tamanho da matriz: ");

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Linha {0}:", i + 1);
                String[] val = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(val[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            int[] diagonal = new int[n];

            for (int m = 0; m < n; m++) {
                diagonal[m] = mat[m, m];
            }

            for (int m = 0; m < n; m++) {
                Console.Write(diagonal[m] + " ");
            }
            Console.WriteLine();

            int negativos = 0;

            for (int o = 0; o < n; o++) {
                for (int p = 0; p < n; p++) {
                    if (mat[o, p] < 0) {
                        negativos += 1;
                    }
                }
            }
            Console.WriteLine("Quantidade de números negativos = " + negativos);
        }
    }
}
