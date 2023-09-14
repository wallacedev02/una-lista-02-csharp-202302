using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o total de veículos: ");
        int totalVeiculos = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o total de rodas: ");
        int totalRodas = int.Parse(Console.ReadLine());


        int numeroCarros = totalRodas / 4;
        int numeroMotos = (totalRodas - (numeroCarros * 4)) / 2;

        Console.WriteLine($"No estacionamento, há {numeroCarros} carros e {numeroMotos} motos.");
    }
}


