class Caminhao : Veiculo
{
    public double CapacidadeCarga;

    public void ReceberDadosCaminhao()
    {
        ReceberDados();

        Console.Write("Capacidade de carga (kg): ");
        CapacidadeCarga = double.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 500;
    }

    public override void MostrarDados()
    {
        Console.WriteLine(" DADOS DO CAMINHÃO ");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Capacidade de carga: " + CapacidadeCarga + " kg");
        Console.WriteLine("Custo de manutenção: R$ " + CalcularCustoManutencao());
    }
}