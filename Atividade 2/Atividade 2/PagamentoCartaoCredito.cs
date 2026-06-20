internal class PagamentoCartaoCredito : Pagamento
{
    int QtParcelas;
    double ValorParcela;

    public void ReceberDadosCartao()
    {
        Console.WriteLine("Quantidade de parcelas");
        QtParcelas = int.Parse(Console.ReadLine());

        if (QtParcelas <= 0)
        {
            QtParcelas = 1;
        }

    }


    public void ProcessarPagamentoCartao()
    {
        ValorParcela = Valor / QtParcelas;
        Console.WriteLine("Pagamento aprovado !!");
    }

    public void MostrarPagamentoCartao()
    {
        base.MostrarPagamento();
        Console.WriteLine($"Quantidade de parcelas: {QtParcelas}");
        Console.WriteLine($"Valor da parcelas: {ValorParcela}");
    }
}