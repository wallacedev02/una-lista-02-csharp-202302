double SalarioFixo, TotalDeVendas, Porcentagem, salarioTotal;

Console.WriteLine("Qual o salario Fixo: ");
SalarioFixo = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o Total de vendas no mês ? ");
TotalDeVendas = double.Parse(Console.ReadLine());


Console.WriteLine("Qual a porcentagem de lucro sobre as vendas? ");
Porcentagem = double.Parse(Console.ReadLine());

salarioTotal = (TotalDeVendas * Porcentagem)+ SalarioFixo;

Console.WriteLine("O salario total do vendedor é: "+ salarioTotal);


