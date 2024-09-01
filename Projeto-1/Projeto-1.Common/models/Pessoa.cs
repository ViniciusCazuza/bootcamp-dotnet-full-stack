using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_1.Common.models;

namespace Projeto_1.Common.models
{   


    
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Id { get; set; } 
        
        

        public void CadastroNome()
        {
            
            Console.WriteLine($"\n\n\nOlá {Nome}, seu nome foi registrado com sucesso! ");

        }


    }




    public class DataNascimento
    {
    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public int Idade { get; set; }
    public string NomeId { get; set; }

        public void CadastroData()
        {
            
           if (Dia != 0 & Mes  != 0 & Ano != 0)
           {

            DateTime hoje = DateTime.Now;

            int dia = Dia, ano = Ano, mes = Mes;
            
                
            string diaString = dia.ToString(), mesString = mes.ToString(), anoString = ano.ToString();
            
            if(dia < 10)
            {
                diaString = ("0" + diaString);
            }
            if(mes < 10)
            {
                mesString = ("0" + mesString);
            }

            string anoHoje = hoje.ToString("yyyy"), diaHoje = hoje.ToString("dd"), mesHoje = hoje.ToString("MM");
             
            string dataCompleta = ($"{diaString}/{mesString}/{anoString}");

            int diaHojeInteiro = Convert.ToInt32(diaHoje), anoHojeInteiro = Convert.ToInt32(anoHoje);
            decimal mesHojeInteiro = Convert.ToDecimal(mesHoje);
            
            if (mesHojeInteiro < Mes)
            {
                Idade = ((anoHojeInteiro - Ano) - 1);
            }
                else if ( mesHojeInteiro == Mes )
                {
                    if (diaHojeInteiro >= Dia)
                    {
                        Idade = (anoHojeInteiro - Ano);
                    }
                    else 
                    {
                        Idade = ((anoHojeInteiro - Ano) - 1);
                    }
                
                }
                else if (mesHojeInteiro > Mes )
                {
                    Idade = (anoHojeInteiro - Ano);
                }

            if (diaHojeInteiro == Dia)
            {   
                Console.Clear();
                Console.WriteLine($"\n\n\n\n\n{NomeId}, Data de Nascimento cadastrada com sucesso! \n"+
                $"A sua Data de Nascimento é {dataCompleta} e a sua idade é {Idade} Anos, e hoje é seu Aniversário, Parebéns\n\n");
                Console.ReadKey();
            }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\n\n\n\n\n{NomeId}, Data de Nascimento cadastrada com sucesso! \n" + 
                    $"A sua Data de Nascimento é {dataCompleta} e a sua idade é {Idade} Anos.\n\n");
                    Console.ReadKey();
                }

            }
           

           else 
            { 

                if (Dia == 0)
                {   
                    Console.Clear();
                    Console.WriteLine("\n\n\nVocê digitou um caracter inválido no seu Dia de Nascimento,\nPor gentileza insira novamente\n\n");
                    Console.ReadKey();
                }
                else if (Mes == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\nVocê digitou um caracter inválido no seu Mês de Nascimento,\nPor gentileza insira novamente\n\n");
                    Console.ReadKey();
                }
                else if (Ano == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\nVocê digitou um caracter inválido no seu Ano de Nascimento,\nPor gentileza insira novamente\n\n");
                    Console.ReadKey();
                }



            }
        }
    }
}