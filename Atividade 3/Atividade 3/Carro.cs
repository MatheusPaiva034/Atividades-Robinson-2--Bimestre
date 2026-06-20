class Carro : Veiculo
{
    public int QuantidadePortas;

    public void ReceberDadosCarro()
    {
        ReceberDados();

        Console.Write("Quantidade de portas: ");
        QuantidadePortas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 200;
    }

    public override void MostrarDados()
    {
        Console.WriteLine(" DADOS DO CARRO ");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Quantidade de portas: " + QuantidadePortas);
        Console.WriteLine("Custo de manutenção: R$ " + CalcularCustoManutencao());
    }
}
