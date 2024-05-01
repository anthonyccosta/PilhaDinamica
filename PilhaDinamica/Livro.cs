using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            this.anterior = null;
        }

        public override string? ToString()
        {
            return "\n\nTitulo do Livro: " + titulo;
        }

        public void setAnterior(Livro livro)
        {
            anterior = livro;
        }

        public Livro GetAnterior()
        {
            return anterior;
        }

        public string getTitulo()
        {
            return titulo;
        }
    }
}
