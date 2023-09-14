double Horas, valorHora, SalarioFamilia, SalarioBruto;
int Filhos;

Console.WriteLine("Quantas Horas trabalhadas ?");
Horas = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor da hora ?");
valorHora = double.parse(Console.ReadLine());

Console.WriteLine("Qual o valor do salario familia?");
valorHora = double.parse(Console.ReadLine());

Console.WriteLine("Quatos filhos menores de 14 anos ?");
Filhos = int.parse(Console.ReadLine());

SalarioBruto = (Horas * valorHora)+(SalarioFamilia/Filhos);

Console.WriteLine("Salario Bruto = "+ SalarioBruto);



