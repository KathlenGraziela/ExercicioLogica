using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3 - As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas pelo
//menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o custo total da
//compra. 

namespace ExercicioLogica
{
    public class Ex03 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Digite a quatidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            double valor = 0;
            
            if (quantidade < 12)
                valor = quantidade * 1.30;
            else
                valor = quantidade * 1.00;

            Console.Write($"Valor à pagar: R$ {valor.ToString("0.00")}");
        }
    }
}
