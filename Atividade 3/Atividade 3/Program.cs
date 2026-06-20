class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();
        Moto moto = new Moto();
        Caminhao caminhao = new Caminhao();

        Console.WriteLine(" CADASTRO DO CARRO ");
        carro.ReceberDadosCarro();

        Console.WriteLine(" CADASTRO DA MOTO ");
        moto.ReceberDadosMoto();

        Console.WriteLine("CADASTRO DO CAMINHÃO ");
        caminhao.ReceberDadosCaminhao();

       

        carro.MostrarDados();
        moto.MostrarDados();
        caminhao.MostrarDados();

        Console.ReadKey();
    }
}