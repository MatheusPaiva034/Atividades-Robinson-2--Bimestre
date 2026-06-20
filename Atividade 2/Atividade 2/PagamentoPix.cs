internal class PagamentoPix : Pagamento
{
    string ChavePix;

    public void ReceberDadosPix()
    {
        Console.WriteLine("Digite a chave pix");
        ChavePix = Console.ReadLine();
    }

    public void ProcessarPagamentoPix()
    {
        Console.WriteLine("");
        Console.WriteLine("O pagamento via PIX foi aprovado com sucesso !");
    }

    public void MostrarPagamentoPix()
    {
        base.MostrarPagamento();
        Console.WriteLine($"Chave PIX: {ChavePix}");
        Console.WriteLine($"Status do pagamento: aprovado !");
    }
}