using bytebank;

Console.WriteLine("Boas Vindas ao seu Banco, ByteBank!");


ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Andre Silva";
conta1.conta = "10123 - x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Silva";
conta2.conta = "111999 - x";
conta2.numero_agencia = 58;
conta2.nome_agencia = "Agencia Central";
conta2.saldo = 100;


//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Numero Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome Agencia: " + conta1.nome_agencia);
//Console.WriteLine("saldo: " + conta1.saldo);

Console.WriteLine("Saldo da Amanda pre-saque: " +conta2.saldo);

bool saque = conta2.Sacar(50);

Console.WriteLine("Saque realizardo? "+saque);

Console.WriteLine("Saldo da Amanda pos-saque: " + conta2.saldo);

conta2.Depositar(60);

Console.WriteLine("Saldo da Amanda pos-deposito: " + conta2.saldo);

//Console.WriteLine("Titular: " + conta3.titular);
//Console.WriteLine("Conta: " + conta3.conta);
//Console.WriteLine("Numero Agencia: " + conta3.numero_agencia);
//Console.WriteLine("Nome Agencia: " + conta3.nome_agencia);
//Console.WriteLine("saldo: " + conta3.saldo);
//Console.WriteLine("Verificador: " + conta3.verificador);

Console.ReadKey();