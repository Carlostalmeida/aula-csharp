using ModuloCliente;

Cliente cliente = new Cliente();
cliente.Nome = "Andre";
cliente.Cpf = "111.222.333-44";
cliente.Email = "andre@email.com";
cliente.Idade = 23;

Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.Cpf);
Console.WriteLine(cliente.Idade);

Console.WriteLine(cliente.ToString());

