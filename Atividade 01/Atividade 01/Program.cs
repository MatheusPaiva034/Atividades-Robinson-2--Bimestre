Console.WriteLine("FUNCIONÁRIO CLT");
FuncionarioCLT clt = new FuncionarioCLT();
clt.ReceberDadosCLT();

Console.WriteLine();

Console.WriteLine("FUNCIONÁRIO COMISSIONADO");
FuncionarioComissionado comissionado = new FuncionarioComissionado();
comissionado.ReceberDadosComissionado();

Console.WriteLine();
Console.WriteLine("RESULTADOS");
Console.WriteLine();
clt.MostrarDados();
Console.WriteLine();
comissionado.MostrarDados();