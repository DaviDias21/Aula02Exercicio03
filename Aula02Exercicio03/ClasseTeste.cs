using System;

namespace Aula02Exercicio03
{
    class ClasseTeste
    {
        static void Main(string[] args)
        {
            Produto[] carrinho = new Produto[5];

            carrinho[0] = new Livro("George R. R. Martin", "Guerra dos Tronos", 60f);
            carrinho[1] = new JogoDigital("Xbox One", "Forza Horizon 4", 170f);
            carrinho[2] = new Livro("Arthur Conan Doyle", "Coleção Sherlock Holmes", 80f);
            carrinho[3] = new JogoDigital("PlayStation 4", "God of War", 140f);
            carrinho[4] = new JogoDigital("Nintendo Switch", "Super Mario Odyssey", 350f);

            ProcessarCarrinho(carrinho);
            Console.ReadLine();
        }

        public static void ProcessarCarrinho(Produto[] carrinho_)
        {
            int indiceCarrinho = 1;

            Console.WriteLine("Conteúdo do carrinho:\n");

            foreach(Produto produto_ in carrinho_)
            {
                Console.WriteLine("Item "+indiceCarrinho+" :");
                Console.WriteLine(produto_.InformarDescricao());
                Console.WriteLine("Preço: R$"+ produto_.InformarPreco());
                Console.WriteLine();
                indiceCarrinho++;
            }
        }
    }
}
