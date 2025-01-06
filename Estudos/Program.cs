using ExemploFundamentos.Models;
using lojaOnline;

// pessoa
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Luane";
pessoa1.cargo = "Vendedora de Bolos";

pessoa1.Apresentar();

// Loja Online

Estoque estoque = new Estoque();
int Bolos = estoque.quantidadeEmEstoque;

Console.WriteLine($"Temos {Bolos} bolos pra venda.");
Console.WriteLine("Quantos bolos você quer comprar?");
    int quantidadeComprada = int.Parse(Console.ReadLine());

    if (estoque.PodeVender(quantidadeComprada))
    {
        Console.WriteLine("Venda realizada com sucesso!");
    }
    else
    {
        Console.WriteLine("Desculpe não temos a quantidade em estoque.");
    }
