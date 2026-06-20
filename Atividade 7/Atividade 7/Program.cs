class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor da compra: R$ ");
        decimal valorCompra = decimal.Parse(Console.ReadLine());

        IDesconto descontoComum = new DescontoClienteComum();
        IDesconto descontoVip = new DescontoClienteVip();

        Console.WriteLine("\nValor original: R$ " + valorCompra);

        Console.WriteLine("\nCliente Comum (5% de desconto)");
        Console.WriteLine("Valor final: R$ " + descontoComum.Calcular(valorCompra));

        Console.WriteLine("\nCliente VIP (10% de desconto)");
        Console.WriteLine("Valor final: R$ " + descontoVip.Calcular(valorCompra));

        Console.ReadKey();
    }
}