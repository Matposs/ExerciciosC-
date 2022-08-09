using System;
namespace ListaExercicio
{
    class Exe02
    {
                /*Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo devereceber o valor em real (R$)
                  e apresentar os valores convertidos em:a) Dólar (1 dólar = 5,18 reais)b) Euro 
                  1 euro = 5,31 reais)c) Peso argentino (1 peso argentino = 0,04 reais */
        public static void renderizar ()
        {
            Console.WriteLine("Exercicio 02");
            Console.WriteLine("Informe o valor em R$");
            double reais = Convert.ToDouble(Console.ReadLine());
            double dolar = reais/5.18;
            double euro = reais/ 5.31;
            double pesos = reais/ 0.04;
            Console.WriteLine($"Esse mesmo valor equivale a: {dolar} dólares, {euro} euros, {pesos} pesos");

        }
    }
}