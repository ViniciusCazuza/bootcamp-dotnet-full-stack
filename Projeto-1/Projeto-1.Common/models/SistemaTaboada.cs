using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_1.Common.models;

namespace Projeto_1.Common.models
{
    public class Taboada
    {   



        public void Menu()
        {

            int cont, x, soma, subtracao, sub, multiplicacao; 
            double divisao;
            bool exit = false; 


                while (exit == false)
                {
                
                Console.Clear();
                Console.WriteLine(    
                    
                    $"Olá, você escolheu a opção Taboada, por gentileza escolha a sua opção: \n\n" +
                "1 - Soma \n" +
                "2 - Subtração \n" +
                "3 - Multiplicação \n" +
                "4 - Divisão \n" +
              "\n0 - Voltar \n\n"
                    );
                
                    string opcao = Console.ReadLine();



                    switch (opcao)
                    {
                    
                    
                        case "1":

                        Console.Clear();
                        Console.WriteLine(
                            
                            $"Você escolheu a Taboada de Soma: \n" +
                            "Por gentileza digite o valor da sua Taboada:"
                        );

                        x = Convert.ToInt32(Console.ReadLine());

                        for (cont = 1; cont <= 10; cont++ )
                        {
                            soma = cont + x;
                            Console.WriteLine($" {cont} + {x} = {soma}");
                        }
                            Console.ReadKey();
                        break;



                        case "2":

                        Console.Clear();
                        Console.WriteLine(
                            
                            $"Você escolheu a Taboada de Subtração: \n" +
                            "Por gentileza digite o valor da sua Taboada:"
                        );

                        x = Convert.ToInt32(Console.ReadLine());
                        sub = x;

                        for (cont = 0; cont <= 10; cont++ )
                        {
                            subtracao = sub - x ;
                            Console.WriteLine($" {sub} - {x} = {subtracao}");
                            sub++;
                        }
                            Console.ReadKey();
                        break;
                        
                        
                        case "3":

                        Console.Clear();
                        Console.WriteLine(
                            
                            $"Você escolheu a Taboada de Multiplicação: \n" +
                            "Por gentileza digite o valor da sua Taboada:"
                        );

                        x = Convert.ToInt32(Console.ReadLine());

                        for (cont = 1; cont <= 10; cont++ )
                        {
                            multiplicacao = cont * x;
                            Console.WriteLine($" {cont} * {x} = {multiplicacao}");
                        }
                            Console.ReadKey();
                        break;
                        
                        
                        
                        case "4":

                        Console.Clear();
                        Console.WriteLine(
                            
                            $"Você escolheu a Taboada de Divisão: \n" +
                            "Por gentileza digite o valor da sua Taboada:"
                        );

                        x = Convert.ToInt32(Console.ReadLine());
                        double div = x;

                        for (cont = 0; cont <= 10; cont++ )
                        {
                            divisao = div / x;
                            divisao = Math.Round(divisao, 4);
                            Console.WriteLine($" {div} / {x} = {divisao}");
                            div++;
                        }
                            Console.ReadKey();
                        break;

                        
                        case "0":
                        exit = true;
                        break;


                        default:
                        Console.WriteLine("Você digitou uma opção invalida, por gentileza tente novamente!");
                        break;

                    }
            
                }

               

        }   
    }
}