internal class Pagamento
{
    public string NomeCliente;
    public double Valor;

    public void ReceberDados()
    {
        Console.Write("Digite o nome do cliente: ");
        NomeCliente = Console.ReadLine();

        Console.Write("Digite o valor do pagamento: ");
        Valor = double.Parse(Console.ReadLine());
    }

    public void ProcessarPagamento()
    {
        Console.Write("O pagamento foi processado ");
    }

    public void MostrarPagamento()
    {
        Console.WriteLine($"Nome do cliente: {NomeCliente} ");
        Console.WriteLine($"Valor do pagamento: {Valor}");
    }


}