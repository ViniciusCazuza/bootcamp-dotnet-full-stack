using PessoaFisica.models;


Pessoa pessoa1 = new Pessoa();
DataNascimento data = new DataNascimento();
DataNascimento error = new DataNascimento();


Console.WriteLine($"\n\nOlá, Qual é o seu Primeiro Nome ? \n\n");

pessoa1.Nome = Console.ReadLine();
string nome = pessoa1.Nome;
var errorMessage = false;
Console.WriteLine($"\n\nÓtimo, agora qual é o seu Segundo Nome ? \n\n");

pessoa1.Sobrenome = Console.ReadLine();


pessoa1.CadastroNome();



    Console.WriteLine($"\nAgora vamos cadastrar a sua Data de Nascimento.\n");
    while (errorMessage == false ) 
    {
        Console.WriteLine($"\n\nEm que dia você Nasceu ? \n\n");
        var respostaDia = Console.ReadLine();
        errorMessage = int.TryParse(respostaDia, out int b);

        if (errorMessage == true)
        {

            data.Dia = Convert.ToInt32(respostaDia);
        
        }

        Console.WriteLine($"\n{nome}, agora me diga o mês em que você Nasceu ? \n\n");
        var respostaMes = Console.ReadLine();
        errorMessage = int.TryParse(respostaMes, out b);

        if (errorMessage == true)
        {
            
            data.Mes = Convert.ToInt32(respostaMes);

        }


        Console.WriteLine($"\n{nome}, Por favor me diga o ano que você Nasceu ? \n\n");
        var respostaAno = Console.ReadLine();
        errorMessage = int.TryParse(respostaAno, out b);
        if (errorMessage == true)
        {

            data.Ano = Convert.ToInt32(respostaAno);
        
        }
        data.CadastroData();

        if (data.Dia == 0 || data.Mes == 0 || data.Ano == 0)
        {
            errorMessage = false;

        }
    }




