using System;

public class FuncionarioComissionado : Funcionario
{
    public double TotalVendas { get; set; }
    public double PercentualComissao { get; set; }

    public void ReceberDadosComissionado()
    {
        ReceberDados();

        Console.Write("Total de vendas: ");
        double.TryParse(Console.ReadLine(), out double vendas);
        TotalVendas = vendas;

        Console.Write("Percentual de comissão (%): ");
        double.TryParse(Console.ReadLine(), out double percentual);
        PercentualComissao = percentual;
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + (TotalVendas * PercentualComissao / 100);
    }

    public override void MostrarDados()
    {
        Console.WriteLine("--- Funcionário Comissionado ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário base: R$ {SalarioBase:F2}");
        Console.WriteLine($"Total de vendas: R$ {TotalVendas:F2}");
        Console.WriteLine($"Percentual de comissão: {PercentualComissao}%");
        Console.WriteLine($"Salário final: R$ {CalcularSalarioFinal():F2}");
    }
}
