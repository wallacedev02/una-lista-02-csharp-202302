
using System;
class Program
{
    static void Main()
    {

        float preco;
        Console.WriteLine("Qual o preço do produto ?")

        preco = float.parse(Console.ReadLine());

        NewValor = preco*0.10;

        Console.WriteLine("O novo valor do produto é: "+NewValor)
    }
    
}