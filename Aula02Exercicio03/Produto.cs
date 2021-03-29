using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02Exercicio03
{
    class Produto
    {
        private String descricao;
        private float preco;

        protected string Descricao { get => descricao; set => descricao = value; }
        protected float Preco { get => preco; set => preco = value; }

        public Produto(float preco_)
        {
            this.Descricao = "Item da loja";
            this.Preco = preco_;
        }

        public Produto()
        {
            this.Descricao = "Item da loja";
        }

        public float InformarPreco()
        {
            return this.Preco;
        }

        public String InformarDescricao()
        {
            return this.Descricao;
        }
    }


}
