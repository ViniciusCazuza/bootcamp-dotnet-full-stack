using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PessoaFisica.models;


namespace SistemaCalculadora.models
{
    public class Calculadora
    {

        Pessoa Nome = new Pessoa();
        public string IdCalculadora { get; set; }


        public void Menu ()
        {

            int soma, subtracao, multiplicacao, divisao, x, y;
            double potencia, raizQuadrada, radiano, seno, coseno, tangente;
            string opcao;
            bool calc = true;
            

            while (calc)
            {
                Console.Clear();
                Console.WriteLine (
                
                    $"Olá, você está na aba Calculadora, \n" + 
                "por gentileza me diga, qual operação deseja fazer ? \n\n" + 
                "1 - Soma \n" + 
                "2 - Subtração \n" +
                "3 - Multiplicação \n" +
                "4 - Divisão \n" +
                "5 - Potenciação \n" +
                "6 - Raiz Quadrada \n" +
                "7 - Seno \n" +
                "8 - Coseno \n" +
                "9 - Tangente \n" +
                "\n0 - Voltar \n\n"
                
                );

                opcao = Console.ReadLine();


                switch (opcao)
                {

                    case "1":

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Soma como opção! \n" +
                    "Por gentileza informe os números que deseja Somar: \n" + 
                    $"(  ) + (  ) = (  )"

                    );
                    
                    x = Convert.ToInt32(Console.ReadLine());
 
 
                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Soma como opção! \n" +
                    "Por gentileza informe os números que deseja Somar: \n" + 
                    $"{x} + (  ) = (  )"

                    );
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    soma = x + y;

                    Console.Clear();
                    Console.WriteLine( 
                        
                        $"Você escolheu Soma como opção! \n" +
                    $"O resultado é \n"  + 
                    $"{x} + {y} = {soma}");
                    Console.ReadKey();
                    break;
                    
                    

                    case "2":

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Subtrair como opção! \n" +
                    "Por gentileza informe os números que deseja Subtrair: \n" + 
                    $"(  ) - (  ) = (  )"

                    );
                    
                    x = Convert.ToInt32(Console.ReadLine());


                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Subtrair como opção! \n" +
                    "Por gentileza informe os números que deseja Subtrair: \n" + 
                    $"{x} - (  ) = (  )"

                    );
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    subtracao = x - y;

                    Console.Clear();
                    Console.WriteLine( 
                        
                        $"Você escolheu Subtrair como opção! \n" +
                    $"O resultado é \n"  + 
                    $"{x} - {y} = {subtracao}");
                    Console.ReadKey();
                    break;
                    
                    

                    case "3":
                    
                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Multiplicação como opção! \n" +
                    "Por gentileza informe os números que deseja Multiplicar: \n" + 
                    $"(  ) * (  ) = (  )"

                    );
                    
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Multiplicação como opção! \n" +
                    "Por gentileza informe os números que deseja Multiplicar: \n" + 
                    $"{x} * (  ) = (  )"

                    );
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    multiplicacao = x * y;

                    Console.Clear();
                    Console.WriteLine( 
                        
                        $"Você escolheu Divisão como opção! \n" +
                    $"O resultado é \n"  +  
                    $"{x} * {y} = {multiplicacao}");
                    Console.ReadKey();
                    break;
                    

                    case "4":
                    Console.Clear();
                    Console.WriteLine(

                        $"Você escolheu Divisão como opção! \n" +
                    "Por gentileza informe os números que deseja Dividir: \n" + 
                    "(  ) / (  ) = (  )"
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Divisão como opção! \n" +
                    "Por gentileza informe os números que deseja Dividir: \n" + 
                    $"{x} / (  ) = (  )"

                    );
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    divisao = x / y;

                    Console.Clear();
                    Console.WriteLine( 
                        
                        $"Você escolheu Divisão como opção! \n" +
                    $"O resultado é \n"  + 
                    $"{x} / {y} = {divisao}");
                    Console.ReadKey();
                    break;


                    case "5":
                    Console.Clear();
                    Console.WriteLine(

                        $"Você escolheu Potenciação como opção! \n" +
                    "Por gentileza informe os números que deseja Elevar: \n" + 
                    "(  ) ^ (  ) = (  )"
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Potenciação como opção! \n" +
                    "Por gentileza informe os números que deseja Elevar: \n" + 
                    $"{x} ^ (  ) = (  )"

                    );
                    
                    y = Convert.ToInt32(Console.ReadLine());

                    potencia = Math.Pow(x, y);

                    Console.Clear();
                    Console.WriteLine( 
                        
                        $"Você escolheu Potenciação como opção! \n" +
                    $"O resultado é \n"  + 
                    $"{x} ^ {y} = {potencia}");
                    Console.ReadKey();
                    break;
                    
                    
                    
                    case "6":
                    Console.Clear();
                    Console.WriteLine(

                        $"Você escolheu Raiz Quadrada como opção! \n" +
                    "Por gentileza informe o número que deseja calcular: \n" + 
                    "√( ) = (  )"
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    raizQuadrada = Math.Sqrt(x);

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Raiz Quadrada como opção! \n" +
                    $"O resultado é \n"  + 
                    $"√{x} = {raizQuadrada}"
                    
                    );

                    Console.ReadKey();
                    break;



                    case "7":
                    Console.Clear();
                    Console.WriteLine(

                        $"Você escolheu Seno como opção! \n" +
                    "Por gentileza informe o ângulo que deseja calcular: \n" + 
                    "O Seno de ( )º = (  )"
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    radiano = x * Math.PI / 180;
                    seno = Math.Sin(radiano);
                    seno = Math.Round(seno, 4);

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Seno como opção! \n" +
                    $"O resultado é \n"  + 
                    $"O Seno de {x}º = {seno}"
                    
                    );

                    Console.ReadKey();
                    break;
                    
                    
                    
                    case "8":
                    Console.Clear();
                    Console.WriteLine(

                        $"Você escolheu Coseno como opção! \n" +
                    "Por gentileza informe o ângulo que deseja calcular: \n" + 
                    "O Coseno de ( )º = (  )"
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    radiano = x * Math.PI / 180;
                    coseno = Math.Cos(radiano);
                    coseno = Math.Round(coseno, 4);

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Coseno como opção! \n" +
                    $"O resultado é \n"  + 
                    $"O Coseno de {x}º = {coseno}"
                    
                    );

                    Console.ReadKey();
                    break;
                    
                    
                    
                    case "9":
                    Console.Clear();
                    Console.WriteLine(

                        $"Você escolheu Tangente como opção! \n" +
                    "Por gentileza informe o ângulo que deseja calcular: \n" + 
                    "A Tangente de ( )º = (  )"
                    
                    );

                    x = Convert.ToInt32(Console.ReadLine());

                    radiano = x * Math.PI / 180;
                    tangente = Math.Tan(radiano);
                    tangente = Math.Round(tangente, 4);

                    Console.Clear();
                    Console.WriteLine(
                        
                        $"Você escolheu Tangente como opção! \n" +
                    $"O resultado é \n"  + 
                    $"A Tangente de {x}º = {tangente}"
                    
                    );

                    Console.ReadKey();
                    break;

                    
                    case "0":
                    calc = false;
                    break;


                    default:
                    Console.WriteLine("Opção invalida, tente novamente!");
                    Console.ReadKey();
                    break;
                    


                }

            }
            
        }

    }
}