using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02Exercicio03
{
    class JogoDigital : Produto
    {
        private String console;
        private String titulo;
        public string Console { get => console; set => console = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        public JogoDigital(String console_, String titulo_, float preco_)
        {
            base.Preco = preco_;
            this.Console = console_;
            this.Titulo = titulo_;

            base.Descricao += "\nTítulo: " + this.titulo + "\nConsole: " + this.console;
        }
    }
}
