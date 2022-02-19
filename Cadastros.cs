using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01
{
    internal class Cadastros
    {
        public Cadastros()
        {
        
        
        }
        /// <summary>
        /// Interface com os metodos Inserir,Alterar,Deletar,Pesquisar
        /// </summary>
        public interface IOperacoesBD
        {
            public void Inserir();
            public void Alterar();
            public void Deletar();
            public void Pesquisar();
        }

        /// <summary>
        /// Classe Abstrata que assina contrato com a Interface IOperacoesBD com implementacao da conexao
        /// </summary>
        public abstract class cadastros : IOperacoesBD
        {
            protected virtual int conexao { get; set; }
            public virtual void Inserir()
            {
            }
            public virtual void Alterar()
            { 
            }
            public virtual  void Deletar()
            { 
            }
            public virtual void Pesquisar()
            {
               
            }
        }

        /// <summary>
        /// Classe derivada da classe cadastros com re-implementação de algumas funcoes e valores
        /// </summary>
        public sealed class Clientes : cadastros
        {

            protected override int conexao { get { return conexao; } set {conexao = 10; } }
            public override void Deletar()
            { 
                base.Deletar();
                int T1 = 10, T2 = 5;
                Console.WriteLine("Essa e a soma gerada na execucao da classe Deletar Reimplementada em Clientes : " + (T1 + T2 + 10));
            }
        }

        /// <summary>
        /// Classe derivada da classe cadastros com re-implementação de algumas funcoes e valores
        /// </summary>
        public sealed class Pedidos : cadastros
        {

            protected override int conexao { get { return conexao; } set { conexao =  20; } }
            public override void Deletar() 
            {
                base.Deletar();
               Console.WriteLine("DELETAR : Essa implementacao veio de Pedidos, Classe derivada de cadastros");
            }

            public override void Inserir()
            {
                Console.WriteLine("Esse metodo foi completamente reescrito e nao leva em conta a sua implementacao hierarquica");
            
            }
        }



    }
}
