
PagamentoPix _pagamentoPix = new PagamentoPix();
PagamentoCartaoCredito _pagamentoCartaoCredito = new PagamentoCartaoCredito();

int op;

Console.WriteLine("--- Forma de pagamento ---");
Console.WriteLine("1- PIX ");
Console.WriteLine("2- Cartão de crédito ");
op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        _pagamentoPix.ReceberDados();
        _pagamentoPix.ReceberDadosPix();

        _pagamentoPix.ProcessarPagamento();
        _pagamentoPix.ProcessarPagamentoPix();

        _pagamentoPix.MostrarPagamentoPix();
        break;

    case 2:
        _pagamentoCartaoCredito.ReceberDados();
        _pagamentoCartaoCredito.ReceberDadosCartao();

        _pagamentoCartaoCredito.ProcessarPagamento();
        _pagamentoCartaoCredito.ProcessarPagamentoCartao();

        _pagamentoCartaoCredito.MostrarPagamentoCartao();
        break;
}