public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double SalarioBase { get; set; }

    public void ReceberDados()
    {
        Console.Write("Nome: ");
        Nome = Console.ReadLine() ?? "";

        Console.Write("Cargo: ");
        Cargo = Console.ReadLine() ?? "";

        Console.Write("Salário base: ");
        double.TryParse(Console.ReadLine(), out double salario);
        SalarioBase = salario;
    }

    public virtual double CalcularSalarioFinal()
    {
        return SalarioBase;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário final: R$ {CalcularSalarioFinal():F2}");
    }
}