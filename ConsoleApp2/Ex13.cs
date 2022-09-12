using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. Calcular e
//escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar (total a pagar = total -
//desconto), sabendo - se que:
// Se quantidade <= 5 o desconto será de 2%
// Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// Se quantidade > 10 o desconto será de 5% 

namespace ExercicioLogica
{
    public class Ex13 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Nome do Produto: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Quantidade Adquirida: ");
            int qtdAdquirida = Convert.ToInt32(Console.ReadLine());
            Console.Write("Preço Unitário: R$ ");
            double valorUnitario = Convert.ToDouble(Console.ReadLine());
            
            double valorTotal = qtdAdquirida * valorUnitario;
            Console.WriteLine($"Valor Total: R$ {valorTotal.ToString("0.00")}");

            double valorPagar = 0, valorDesc = 0;

            if(qtdAdquirida <= 5)
            {
                valorDesc = valorTotal * 0.02;
                valorPagar = valorTotal - valorDesc;
            }
            else if(qtdAdquirida >5 && qtdAdquirida <=10)
            {
                valorDesc = valorTotal * 0.03;
                valorPagar = valorTotal - valorDesc;
            }
            else
            {
                valorDesc = valorTotal * 0.05;
                valorPagar = valorTotal - valorDesc;
            }

            Console.WriteLine($"Valor do Desconto R$ {valorDesc.ToString("0.00")} " +
                $"\nValor à pagar: R$ {valorPagar.ToString("0.00")}");
        }
    }
}
