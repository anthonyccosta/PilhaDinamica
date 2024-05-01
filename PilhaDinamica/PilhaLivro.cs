using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PilhaDinamica
{
    internal class PilhaLivro
    {
        Livro topo;

        public PilhaLivro()
        {
           this.topo = null;
            //Console.WriteLine("Pilha criado com sucesso!");
        }

        public void push(Livro aux)
        {
            if (vazia() == true)
            {
                topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
            }
            Boolean vazia()
            {
                if (topo == null)
                    return true;
                else 
                    return false;
            }

        public void print()
        {
            Livro aux = topo;
            if (vazia())
            {
                Console.WriteLine("Pilha Vazia");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.GetAnterior();
                } while (aux != null);
                Console.WriteLine("Fim da Impressão");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        public void pop()
        {
            if(vazia())
            {
                Console.WriteLine("Pilha Vazia! Impossivel Remover");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                topo = topo.GetAnterior();
            }
        }

        public int quantidade()
        {
            Livro aux = topo;
            if (vazia())
            {
                return 0;
            }
            else
            {
                int cont = 0;
                do
                {
                    cont++;
                    aux = aux.GetAnterior();
                } while (aux != null);
                return cont;
            }
        }

        public Livro buscarLivro(string titulo)
        {
            Livro aux = topo;

            while (aux != null)
            {
                if (aux.getTitulo().ToLower() == titulo.ToLower())
                {
                    return aux; 
                }

                aux = aux.GetAnterior();
            }

            return null; 
        }
    }
}
