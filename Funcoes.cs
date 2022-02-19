using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    public class Funcoes
    {

        public Funcoes()
        { 
        
        
        }
        /// <summary>
        /// Funcao Recebe uma matriz de proporcoes x por y preenchida e soma todos seus elementos
        /// </summary>
        /// <param name="array">array bidimensional (Matriz) Preenchida</param>
        /// <returns>Retorna a soma total dos elementos da matriz</returns>
        public int SomaElementosMatriz(int[,] array)
        {

            try
            {
                int somaTotal = 0;

                for (int colunas = 0; colunas < array.GetLength(0); colunas++)
                {
                    for (int linhas = 0; linhas < array.GetLength(1); linhas++)
                    {
                        somaTotal += array[colunas, linhas];
                    }
                }
                return somaTotal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }



        /// <summary>
        /// Funcao para achar o maior valor dentre os passados
        /// </summary>
        /// <param name="v1">Primeiro Valor</param>
        /// <param name="v2">Segundo Valor</param>
        /// <param name="v3">Terceiro Valor</param>
        /// <param name="v4">Quarto Valor</param>
        /// <returns>Retorna o Maior valor</returns>
        public int AchaMaior(int v1, int v2, int v3, int v4)
        {
            try
            {
                int[] array = { v1, v2, v3, v4 };
                int maiorValor = v1;
                for (int i = 0; i < 4; i++)
                {
                    if (maiorValor < array[i])
                    {
                        maiorValor = array[i];
                    }
                }
                return maiorValor;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return 0;
            }
        }
      








    }//fim class
}//fim namespace
