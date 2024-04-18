using System;

class Program
{
    static void Main(string[] args)
    {
        double salario, valorAumento, porcentagem, aumento;

        Console.Write("Digite o salário:");

        salario = double.Parse(Console.ReadLine());

        if (salario <= 280.00)
        {
            porcentagem = 0.20;
        }
        else if (salario <= 700.00)
        {
            porcentagem = 0.15;
        }
        else if (salario <= 1500.00)
        {
            porcentagem = 0.10;
        }
        else
        {
            porcentagem = 0.5;
        }

        valorAumento = (salario * porcentagem) * 100.00;

        aumento = salario + valorAumento;

        Console.WriteLine("Salário antes do reajuste: R$ {0:F2}", salario);
        Console.WriteLine("Aumento Percentual: {0:F2}%", porcentagem * 100);
        Console.WriteLine("Valor do aumento: R$ {0:F2}", valorAumento);
        Console.WriteLine("Novo salário: R$ {0:F2}", aumento);
    }
}