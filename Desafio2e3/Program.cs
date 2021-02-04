using System;
using Produto;
using Livro;
using VideoGame;

class Program {
    static void Main(string[] args) {

        Livro l1 = new Livro("Harry Potter", 40,50,"J.K Rowling","fantasia",300);

        Console.WriteLine(l1.calcularImposto());
    }
}