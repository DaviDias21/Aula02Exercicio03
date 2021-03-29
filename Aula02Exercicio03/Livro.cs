using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02Exercicio03
{
    class Livro : Produto
    {
        private String autor;
        private String titulo;

        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        public Livro(String autor_, String titulo_, float preco_)
        {
            base.Preco = preco_;
            this.Autor = autor_;
            this.Titulo = titulo_;

            base.Descricao += "\nAutor: " + this.autor + "\nTítulo: " + this.titulo;
        }
    }
}
