using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtivSem01;


namespace AtivSem01
{
    class Program { 
    static void Main(string[] args)
    { 
    Funcoes funcoes = new Funcoes();
            int [,] arrayT = new int[,] { {1,2 },{1,2 },{1,2 } };


            Console.WriteLine("FUNCAO SOMA DE TODOS ELEMENTOS DA MATRIZ : ");
            Console.WriteLine(funcoes.SomaElementosMatriz(arrayT));
            Console.WriteLine("MAIOR DOS VALORES INFORMADO: ");
            Console.WriteLine(funcoes.AchaMaior(1,2,3,4));

            Cadastros cadastros = new Cadastros();  
            var a = new Cadastros.Clientes();
            var b = new Cadastros.Pedidos();

            a.Deletar();
            b.Deletar();
            b.Inserir();


            Console.ReadKey();

    }
    }

}