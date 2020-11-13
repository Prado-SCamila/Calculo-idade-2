using System;

namespace Calculo_idade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iSemana, anoNasc , i;
            int anoAtual = 2020;

            Console.WriteLine("Digite seu ano de nascimento");
            anoNasc = int.Parse(Console.ReadLine());

            i = anoAtual - anoNasc;

            Console.WriteLine("Sua idade é: "+i);

            iSemana = i*48;
            Console.WriteLine("Sua idade em semanas é: "+iSemana);

    
        }
    }
}
