using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoaFisica.models
{   


    
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }


        public void CadastroNome()
        {
            Console.WriteLine($"\n\nOlá {Nome}, seu nome foi registrado com sucesso! ");

        }

    }




    public class DataNascimento
    {
    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public int Idade { get; set; }


        public void CadastroData()
        {
            
           if (Dia != 0 & Mes  != 0 & Ano != 0)
           {

            DateTime hoje = DateTime.Now;

            int dia = Dia, ano = Ano, mes = Mes;
            
                
            string diaString = dia.ToString(), mesString = mes.ToString(), anoString = ano.ToString();
            
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
                Console.WriteLine($"\n\nData de Nascimento cadastrada com sucesso! \n"+
                $"A sua Data de Nascimento é {dataCompleta} e a sua idade é {Idade} Anos, e hoje é seu Aniversário, Parebéns\n\n");
            }
                else
                {
                    Console.WriteLine($"\n\nData de Nascimento cadastrada com sucesso! \n" + 
                    $"A sua Data de Nascimento é {dataCompleta} e a sua idade é {Idade} Anos.\n\n");
                }

            }
           

           else 
            { 
                Console.WriteLine("\n\nVocê digitou um caracter inválido, Por gentileza insira novamente\n\n");

                Dia = 0;
                Mes = 0;
                Ano = 0;

            }
        }
    }
}