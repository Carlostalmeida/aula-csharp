using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas, ao Bytebank Administração!");
Console.WriteLine();

//Funcionario joao = new Funcionario();
//joao.Nome = "João";
//joao.Cpf = "123545698";
//joao.Salario = 2000;

//Console.WriteLine("Bonificação: " +joao.getBonificacao());
//Console.WriteLine("Nome: " + joao.Nome);
//Console.WriteLine("CPF: " + joao.Cpf);
//Console.WriteLine("Salario: " + joao.Salario);

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "123545698";
pedro.Salario = 2000;

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "1241661613";
paula.Salario = 5000;


Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salario: " + pedro.Salario);
Console.WriteLine("Bonificação: " + pedro.getBonificacao());

Console.WriteLine();

Console.WriteLine("Nome: " + paula.Nome);
Console.WriteLine("CPF: " + paula.Cpf);
Console.WriteLine("Salario: " + paula.Salario);
Console.WriteLine("Bonificação: " + paula.getBonificacao());

Console.WriteLine();

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());

Console.ReadKey();


