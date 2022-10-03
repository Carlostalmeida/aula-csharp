using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas vindas, ao Bytebank Administração!");

Funcionario joao = new Funcionario();
joao.Nome = "João";
joao.Cpf = "123545698";
joao.Salario = 2000;

Console.WriteLine("Bonificação: " +joao.getBonificacao());

