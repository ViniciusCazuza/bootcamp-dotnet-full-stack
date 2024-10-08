using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_1.Common.models;

namespace Projeto_1.Common.models
{
    public class Cadastro
    {
        public string IdNome { get; set; }
        public void CadastroNomeData()
        {
            Pessoa pessoa1 = new Pessoa();
            DataNascimento data = new DataNascimento();
            DataNascimento error = new DataNascimento();

            
            var errorMessage = false;

            Console.Clear();
            Console.WriteLine($"Olá, Qual é o seu Primeiro Nome ? \n\n");

            pessoa1.Nome = Console.ReadLine();
            string nome = pessoa1.Nome;


            Console.Clear();
            Console.WriteLine($"Ótimo, agora qual é o seu Segundo Nome ? \n\n");

            pessoa1.Sobrenome = Console.ReadLine();
            string sobrenome = pessoa1.Sobrenome;

            data.NomeId = nome + " " +  sobrenome;
            

            pessoa1.CadastroNome();



                Console.Clear();
                Console.WriteLine($"Agora vamos cadastrar a sua Data de Nascimento.\n");
                Console.ReadKey();

                while (errorMessage == false ) 
                {   
                    if (data.Dia == 0)
                    {
                    Console.Clear();
                    Console.WriteLine($"Em que dia você Nasceu ? \n\n");
                    var respostaDia = Console.ReadLine();
                    errorMessage = int.TryParse(respostaDia, out int b);
                    
                    if (errorMessage == true)
                    {

                        data.Dia = Convert.ToInt32(respostaDia);
                    
                    }

                    }

                    if (data.Mes == 0)
                    {
                    Console.Clear();
                    Console.WriteLine($"{nome}, agora me diga o mês em que você Nasceu ? \n\n");
                    var respostaMes = Console.ReadLine();
                    errorMessage = int.TryParse(respostaMes, out int b);

                    if (errorMessage == true)
                    {
                        
                        data.Mes = Convert.ToInt32(respostaMes);

                    }

                    }

                    if (data.Ano == 0)
                    {
                    Console.Clear();
                    Console.WriteLine($"{nome}, Por favor me diga o ano que você Nasceu ? \n\n");
                    var respostaAno = Console.ReadLine();
                    errorMessage = int.TryParse(respostaAno, out int b);
                    
                    if (errorMessage == true)
                    {

                        data.Ano = Convert.ToInt32(respostaAno);
                    
                    }
                    
                    }


                    data.CadastroData();

                    if (data.Dia == 0 || data.Mes == 0 || data.Ano == 0)
                    {
                        errorMessage = false;

                    }
                }

        }
    }
} 