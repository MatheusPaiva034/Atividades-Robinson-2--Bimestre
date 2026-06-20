public class FuncionarioCLT : Funcionario
{
    public double Bonus { get; set; }

    public void ReceberDadosCLT()
    {
        ReceberDados();

        Console.Write("Bônus: ");
        double.TryParse(Console.ReadLine(), out double bonus);
        Bonus = bonus;
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + Bonus;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("--- Funcionário CLT ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário base: R$ {SalarioBase:F2}");
        Console.WriteLine($"Bônus: R$ {Bonus:F2}");
        Console.WriteLine($"Salário final: R$ {CalcularSalarioFinal():F2}");
    }
}
