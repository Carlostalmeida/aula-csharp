using bytebank;

Console.WriteLine("Boas Vindas ao seu Banco, ByteBank!");

// utilizado na aula 1 // string titular = "Andre Bessa";
// utilizado na aula 1 // string conta = "10123 - x";
// utilizado na aula 1 // int numero_agencia = 23;
// utilizado na aula 1 // string nome_agencia = "Agencia Central";
// utilizado na aula 1 // double saldo = 93.50;

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

ContaCorrente conta3 = new ContaCorrente();

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Numero Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome Agencia: " + conta1.nome_agencia);
//Console.WriteLine("saldo: " + conta1.saldo);

Console.WriteLine("Titular: " + conta3.titular);
Console.WriteLine("Conta: " + conta3.conta);
Console.WriteLine("Numero Agencia: " + conta3.numero_agencia);
Console.WriteLine("Nome Agencia: " + conta3.nome_agencia);
Console.WriteLine("saldo: " + conta3.saldo);
Console.WriteLine("Verificador: " + conta3.verificador);

Console.ReadKey();