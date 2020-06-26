using System;

namespace Obj_Argumento_24
{
    class Program
    {
        static void Main(string[] args)
        {
             Carrinho cart = new Carrinho();

            System.Console.WriteLine("Carrinho de compras:");

            Produto p1 = new Produto(1, "Air max 70", 799.99f);
            Produto p2 = new Produto(2, "Calça Tactel", 60f);
            Produto p3 = new Produto(3, "Jaqueta Corta vento", 299.99f);
            Produto p4 = new Produto(4, "Camisa Olic", 99.99f);
            System.Console.WriteLine();
            
            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Remover(p4);

            Produto p5 = new Produto(2, "Blusa Olic", 199.88f);
            cart.Alterar(2, p5);

            

            cart.Ler();
            cart.MostrarTotal();
        }
    }
}
