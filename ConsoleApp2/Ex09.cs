using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9 - A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas
//receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%. Escreva um algoritmo que
//leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do funcionário, que
//deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês possua 4 semanas
//exatas). 

namespace ExercicioLogica
{
    public class Ex09 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Informe o numero de horas: ");
            int numeroHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o salario por hora: ");
            double salarioHora = Convert.ToDouble(Console.ReadLine());
            double salario = 0;

            if (numeroHorasTrabalhadas > 160)
                salario = (160 * salarioHora) + ((numeroHorasTrabalhadas-160) * (salarioHora * 1.50));
            else
                salario = numeroHorasTrabalhadas * salarioHora;

            Console.WriteLine($"Valor à receber R$ {salario.ToString("0.00")}");
        }
    }
}
