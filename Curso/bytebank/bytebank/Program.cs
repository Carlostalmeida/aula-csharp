using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu Banco, ByteBank!");


//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "Andre Silva";
//conta1.conta = "10123 - x";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Silva";
//conta2.conta = "111999 - x";
//conta2.numero_agencia = 58;
//conta2.nome_agencia = "Agencia Central";
//conta2.saldo = 100;

//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.cpf = "10253541263";
//cliente.profissao = "Programador C#";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = new Cliente();
conta3.titular.nome = "Andre Silva";
conta3.titular.cpf = "10253541263";
conta3.titular.profissao = "Programador C#";
conta3.conta = "2513252 - x";
conta3.numero_agencia = 35;
conta3.nome_agencia = "Agencia Central";
conta3.saldo = 100;

Console.WriteLine(conta3.titular.nome);


//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Numero Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome Agencia: " + conta1.nome_agencia);
//Console.WriteLine("saldo: " + conta1.saldo);

//Console.WriteLine(cliente.nome);

//Console.WriteLine("Saldo da Amanda pre-Transferencia: " +conta2.saldo);

//Console.WriteLine("Saldo da Andre pre-Transferenciaa: " + conta1.saldo);

//bool tranferencia = conta1.Transferir(50, conta2);

//Console.WriteLine("Transferencia Realizada com sucesso? " +tranferencia);

//Console.WriteLine("Saldo da Amanda pos-Transferencia: " + conta2.saldo);

//Console.WriteLine("Saldo da Andre pos-Tranferencia: " + conta1.saldo);

Console.ReadKey();