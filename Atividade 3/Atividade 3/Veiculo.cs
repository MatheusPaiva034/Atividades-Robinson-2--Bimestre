using System;

class Veiculo
{
    public string Modelo;
    public int Ano;
    public double ValorBaseManutencao;

    public virtual void ReceberDados()
    {
        Console.Write("Modelo: ");
        Modelo = Console.ReadLine();

        Console.Write("Ano: ");
        Ano = int.Parse(Console.ReadLine());

        Console.Write("Valor base da manutenção: ");
        ValorBaseManutencao = double.Parse(Console.ReadLine());
    }

    public virtual double CalcularCustoManutencao()
    {
        return ValorBaseManutencao;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Custo de manutenção: R$ " + CalcularCustoManutencao());
    }
}