class Program
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();

        double total = 0;

        for (int i = 1; i <= 4; i++)
        {
            Produto p = new Produto();

            Console.WriteLine($"Produto {i}");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            produtos.Add(p);
        }

        Console.WriteLine("\nProdutos cadastrados:");

        foreach (Produto p in produtos)
        {
            Console.WriteLine($"{p.Nome} - R$ {p.Preco:F2}");
            total += p.Preco;
        }

        Console.WriteLine($"\nValor total: R$ {total:F2}");

        Console.ReadKey();
    }
}