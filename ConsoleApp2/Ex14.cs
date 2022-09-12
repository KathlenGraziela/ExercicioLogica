using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

//14 - Uma empresa quer verificar se um empregado está qualificado para a aposentadoria ou não. Para estar em
//condições, um dos seguintes requisitos deve ser satisfeito:
//- Ter no mínimo 65 anos de idade.
//- Ter trabalhado no mínimo 30 anos.
//- Ter no mínimo 60 anos e ter trabalhado no mínimo 25 anos. 
//Com base nas informações acima, faça um algoritmo que leia: o número do empregado (código), o ano de seu
//nascimento e o ano de seu ingresso na empresa. O programa deverá escrever a idade e o tempo de trabalho do
//empregado e a mensagem 'Requerer aposentadoria' ou 'Não requerer'.

namespace ExercicioLogica
{
    public class Ex14 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Informe o Código do Funcionário: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o Ano de Nascimento do Funcionário: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o Ano de Ingresso: ");
            int anoIngresso = Convert.ToInt32(Console.ReadLine());

            int idade = 2022 - anoNascimento;
            int qtdTrabalhado = 2022 - anoIngresso;

            if(idade >= 65)
                Console.WriteLine("Requerer aposentadoria");
            else if(idade >= 60 && qtdTrabalhado >= 25)
                Console.WriteLine("Requerer aposentadoria");
            else if (qtdTrabalhado >= 30)
                Console.WriteLine("Requerer aposentadoria");
            else
                Console.WriteLine("Não requerer aposentadoria");
        }
    }
}
