using CadastroUsuario.models;
using SistemaCalculadora.models;

Cadastro cadastro = new Cadastro();
Calculadora calculadora = new Calculadora();
string opcao;

while (true)
{
Console.Clear();
Console.WriteLine(

    $"Olá, digite a opção que deseja: \n\n" +
    "1 - Cadastrar-me \n" +
    "2 - Calculadora \n" +
    "0 - Sair\n\n"
    );

opcao = Console.ReadLine();

    switch (opcao)
    {

        case "1":
        cadastro.CadastroNomeData();
        break;

        case "2":
        calculadora.Menu();
        break;

        case "0":
        Console.WriteLine("Até logo!");
        Environment.Exit(0);
        break;

        default:
        Console.WriteLine("Opção Invalida, tente novamente!");
        Console.ReadKey();
        break;
    }
}

