using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDotNet.CompetenciaUm
{
    internal class Program
    {
        //O compilador vai chegar aqui 
        static void Main(string[] args)
        { //inicio do algoritmo
            double n1, n2, n3, n4;
            double soma, media;
            string nome;


            //perguntas do Paulo
            //A linguagem c# é Case Sensitive (diferencia maiúscula de minúscula)
            //O sinal "=" significa atribuição
            
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual a primeira nota?");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a segunda nota?");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a terceira nota?");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quarta nota?");
            n4 = double.Parse(Console.ReadLine());


            soma = n1 + n2 + n3 + n4;

            media = soma / 4;
            string msg;
            if (media >= 70)
            {
                msg = "aprovado";
            }
            else
            { 
                msg = "reprovado, se f#$@&";
            }

            Console.WriteLine($"{nome} tirou {media} e foi {msg}.");

            Console.ReadKey();

        }  //fim do algoritmo
        
    }
}
