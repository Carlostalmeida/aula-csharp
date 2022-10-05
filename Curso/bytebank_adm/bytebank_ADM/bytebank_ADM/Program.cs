using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;
using System.Security.Cryptography;

//Console.WriteLine("Boas vindas, ao Bytebank Administração!");
//Console.WriteLine();

////Funcionario joao = new Funcionario();
////joao.Nome = "João";
////joao.Cpf = "123545698";
////joao.Salario = 2000;

////Console.WriteLine("Bonificação: " +joao.getBonificacao());
////Console.WriteLine("Nome: " + joao.Nome);
////Console.WriteLine("CPF: " + joao.Cpf);
////Console.WriteLine("Salario: " + joao.Salario);

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//Funcionario pedro = new Funcionario("123545698", 2000);
//pedro.Nome = "Pedro";
////pedro.Cpf = ;
////pedro.Salario = ;

//Diretor paula = new Diretor("1241661613", 5000);
//paula.Nome = "Paula";
////paula.Cpf = ;
////paula.Salario = ;

//Diretor andre = new Diretor("12258254531", 3000);
//andre.Nome = "Andre";
////andre.Cpf = ;
////andre.Salario = ;


//Console.WriteLine("Nome: " + pedro.Nome);
//Console.WriteLine("CPF: " + andre.Cpf);
//Console.WriteLine("Salario: " + pedro.Salario);
//Console.WriteLine("Bonificação: " + pedro.getBonificacao());
//Console.WriteLine();

//Console.WriteLine("Nome: " + paula.Nome);
//Console.WriteLine("CPF: " + paula.Cpf);
//Console.WriteLine("Salario: " + paula.Salario);
//Console.WriteLine("Bonificação: " + paula.getBonificacao());
//Console.WriteLine();

//Console.WriteLine("Nome: " + andre.Nome);
//Console.WriteLine("CPF: " + andre.Cpf);
//Console.WriteLine("Salario: " + andre.Salario);
//Console.WriteLine("Bonificação: " + andre.getBonificacao());
//Console.WriteLine();

//gerenciador.Registrar(pedro);
//gerenciador.Registrar(paula);
//gerenciador.Registrar(andre);

//Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());

//Console.WriteLine("Total de Funcionarios: " + Funcionario.totalDeFuncionarios);

//andre.AumentarSalario();
//Console.WriteLine("Novo Salario do Andre: " +andre.Salario);

//pedro.AumentarSalario();
//Console.WriteLine("Novo Salario do Pedro: " + pedro.Salario);

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Diretor paula = new Diretor("159.753.398-04");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
}

Console.ReadKey();


