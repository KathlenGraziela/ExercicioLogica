using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//5 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não
//votar este ano (não é necessário considerar o mês em que a pessoa nasceu). 

namespace ExercicioLogica
{
    public class Ex05 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Informe o ano atual: ");
            int anoAtual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o ano nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            int condicao = anoAtual - anoNascimento;

            if (condicao >= 16)
                Console.WriteLine("Você pode votar");
            else
                Console.WriteLine("Você não pode votar");
        }
    }
}
