using System;
namespace EXERCISE_03___MATRICES_M._06 {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            string[] line = Console.ReadLine().Split(' '); // -------- > DECLARAÇÃO DO VETOR | Linha de comando para estrever o VETOR com espaço |
            int m = int.Parse(line[0]); // -------- > Nº de LINHAS da matriz
            int n = int.Parse(line[1]); // -------- > Nº de COLUNAS da matriz

            int[,] mat = new int[m,n]; // -------- > DECLARAÇÃO da matriz

            for (int i=0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' '); // -------- > Entrada dos valor POR LINHA 
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]); // -------- > Nº de LINHAS da matriz
                }
            }

            int x = int.Parse(Console.ReadLine()); // -------- > ENTRADA DO VALOR  a ser pesquisada
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j]== x) {  // -------- >  Parametro da CONDICIONAL
                        Console.WriteLine("Position " +i+","+j+":");
                        if (j > 0) {
                            Console.WriteLine("Left: "+mat[i,j-1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " +mat[i-1,j]);
                        }
                        if(i > n - 1) {
                            Console.WriteLine("Right: "+mat[i,j+1]);
                        }
                        if (i > m - 1) {
                            Console.WriteLine("Down:"+mat[i+1,j]);
                        }
                    }
                }         
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
