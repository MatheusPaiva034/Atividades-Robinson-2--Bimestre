class Program
{
    static void Main(string[] args)
    {
        List<Cliente> clientes = new List<Cliente>();

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU DE CLIENTES =====");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Buscar cliente por nome");
            Console.WriteLine("4 - Remover cliente");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Cliente novoCliente = new Cliente();

                    Console.Write("Nome: ");
                    novoCliente.Nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(novoCliente.Nome))
                    {
                        Console.WriteLine("O nome não pode ficar vazio!");
                        break;
                    }

                    Console.Write("Telefone: ");
                    novoCliente.Telefone = Console.ReadLine();

                    Console.Write("Cidade: ");
                    novoCliente.Cidade = Console.ReadLine();

                    clientes.Add(novoCliente);

                    Console.WriteLine("Cliente cadastrado com sucesso!");
                    break;

                case 2:
                    if (clientes.Count == 0)
                    {
                        Console.WriteLine("Nenhum cliente cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- CLIENTES CADASTRADOS ---");

                        foreach (Cliente c in clientes)
                        {
                            Console.WriteLine("Nome: " + c.Nome);
                            Console.WriteLine("Telefone: " + c.Telefone);
                            Console.WriteLine("Cidade: " + c.Cidade);
                            Console.WriteLine("-------------------------");
                        }
                    }
                    break;

                case 3:
                    Console.Write("Digite o nome do cliente: ");
                    string nomeBusca = Console.ReadLine();

                    bool encontrado = false;

                    foreach (Cliente c in clientes)
                    {
                        if (c.Nome.ToLower() == nomeBusca.ToLower())
                        {
                            Console.WriteLine("\nCliente encontrado:");
                            Console.WriteLine("Nome: " + c.Nome);
                            Console.WriteLine("Telefone: " + c.Telefone);
                            Console.WriteLine("Cidade: " + c.Cidade);

                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Cliente não encontrado.");
                    }
                    break;

                case 4:
                    Console.Write("Digite o nome do cliente que deseja remover: ");
                    string nomeRemover = Console.ReadLine();

                    Cliente clienteRemover = null;

                    foreach (Cliente c in clientes)
                    {
                        if (c.Nome.ToLower() == nomeRemover.ToLower())
                        {
                            clienteRemover = c;
                            break;
                        }
                    }

                    if (clienteRemover != null)
                    {
                        clientes.Remove(clienteRemover);
                        Console.WriteLine("Cliente removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Cliente não encontrado.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }
}