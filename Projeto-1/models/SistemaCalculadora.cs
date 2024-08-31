using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaCalculadora.models
{
    public class Calculadora
    {

        
        public string IdCalculadora { get; set; }

        public void Menu ()
        {

            int soma, subtracao, multiplicacao, divisao, x, y;
            string opcao;
            bool calc = true;
            

            while (calc)
            {
                Console.Clear();
                Console.WriteLine (
                
                    IdCalculadora + $"Olá, você está na aba Calculadora, \n" + 
                "por gentileza me diga, qual operação deseja fazer ? \n\n" + 
                "1 - Soma \n" + 
                "2 - Subtração \n" +
                "3 - Multiplicação \n" +
                "4 - Divisão \n" +
                "0 - Voltar"
                
                );

                opcao = Console.ReadLine();


                switch (opcao)
                {

                    case "1":
                    Console.Clear();
                    Console.WriteLine(

                        $"{IdCalculadora} Você escolheu Soma como opção! \n" +
                    "Por gentileza informe os numero que deseja Somar: \n" + 
                    "1º numero: "
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("2º número:");
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    soma = x + y;

                    Console.WriteLine($"A sua soma de {x} + {y} = {soma}");
                    Console.ReadKey();
                    break;
                    

                    case "2":
                    Console.Clear();
                    Console.WriteLine(

                        $"{IdCalculadora} Você escolheu Subtração como opção! \n" +
                    "Por gentileza informe os numero que deseja Subtrair: \n" + 
                    "1º numero: "
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("2º número:");
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    subtracao = x - y;

                    Console.WriteLine($"O resultado de {x} - {y} = {subtracao}");
                    Console.ReadKey();
                    break;
                    

                    case "3":
                    Console.Clear();
                    Console.WriteLine(

                        $"{IdCalculadora} Você escolheu Multiplicação como opção! \n" +
                    "Por gentileza informe os numero que deseja Multiplicar: \n" + 
                    "1º numero: "
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("2º número:");
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    multiplicacao = x * y;

                    Console.WriteLine($"A sua resultado de {x} * {y} = {multiplicacao}");
                    Console.ReadKey();
                    break;
                    

                    case "4":
                    Console.Clear();
                    Console.WriteLine(

                        $"{IdCalculadora} Você escolheu Divisão como opção! \n" +
                    "Por gentileza informe os numero que deseja Dividir: \n" + 
                    "1º numero:"
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("2º número:");
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    divisao = x / y;

                    Console.WriteLine($"A sua resultado de {x} / {y} = {divisao}");
                    Console.ReadKey();
                    break;
                    
                    case "0":
                    calc = false;
                    break;
                    


                }

            }
            
        }

    }
}