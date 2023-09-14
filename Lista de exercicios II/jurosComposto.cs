double capital, prazo, taxa, montante;

Console.WriteLine("Qual o valor a ser aplicado")
capital = double.Parse(Console.ReadLine())

Console.WriteLine("Qual o prazo da aplicação ?")
prazo = double.Parse(Console.ReadLine())


Console.WriteLine("Qual a taxa de juros?")
taxa = double.Parse(Console.ReadLine())

montante =Math.Pow(capital*(1+taxa),prazo) 

Console.Writeline("O montante a ser recebido= "+montante)




