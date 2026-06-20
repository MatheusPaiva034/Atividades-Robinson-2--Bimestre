class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();

        int opcao;

        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Alterar Aluno");
            Console.WriteLine("4 - Remover Aluno");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                 
                    Console.Write("RA: ");
                    string ra = Console.ReadLine();

                    bool existe = false;

                    foreach (Aluno a in alunos)
                    {
                        if (a.RA == ra)
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (existe)
                    {
                        Console.WriteLine("RA já cadastrado!");
                    }
                    else
                    {
                        Aluno novoAluno = new Aluno();

                        novoAluno.RA = ra;

                        Console.Write("Nome: ");
                        novoAluno.Nome = Console.ReadLine();

                        Console.Write("Idade: ");
                        novoAluno.Idade = int.Parse(Console.ReadLine());

                        alunos.Add(novoAluno);

                        Console.WriteLine("Aluno cadastrado com sucesso!");
                    }
                    break;

                case 2:
                 
                    if (alunos.Count == 0)
                    {
                        Console.WriteLine("Nenhum aluno cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- LISTA DE ALUNOS ---");

                        foreach (Aluno a in alunos)
                        {
                            Console.WriteLine("RA: " + a.RA);
                            Console.WriteLine("Nome: " + a.Nome);
                            Console.WriteLine("Idade: " + a.Idade);
                            Console.WriteLine("-------------------");
                        }
                    }
                    break;

                case 3:
                  
                    Console.Write("Digite o RA do aluno: ");
                    string raAlterar = Console.ReadLine();

                    bool encontrado = false;

                    foreach (Aluno a in alunos)
                    {
                        if (a.RA == raAlterar)
                        {
                            Console.Write("Novo nome: ");
                            a.Nome = Console.ReadLine();

                            Console.Write("Nova idade: ");
                            a.Idade = int.Parse(Console.ReadLine());

                            Console.WriteLine("Aluno alterado com sucesso!");
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("Aluno não encontrado!");
                    }
                    break;

                case 4:
                 
                    Console.Write("Digite o RA do aluno: ");
                    string raRemover = Console.ReadLine();

                    Aluno alunoRemover = null;

                    foreach (Aluno a in alunos)
                    {
                        if (a.RA == raRemover)
                        {
                            alunoRemover = a;
                            break;
                        }
                    }

                    if (alunoRemover != null)
                    {
                        alunos.Remove(alunoRemover);
                        Console.WriteLine("Aluno removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontrado!");
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