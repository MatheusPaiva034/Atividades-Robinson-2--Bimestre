class Moto : Veiculo
{
    public int Cilindradas;

    public void ReceberDadosMoto()
    {
        ReceberDados();

        Console.Write("Cilindradas: ");
        Cilindradas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 100;
    }

    public override void MostrarDados()
    {
        Console.WriteLine(" DADOS DA MOTO ");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Cilindradas: " + Cilindradas);
        Console.WriteLine("Custo de manutenção: R$ " + CalcularCustoManutencao());
    }
}

