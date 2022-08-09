using System;
namespace ListaExercicio
{
    class Exe04
    {
        public static void renderizar ()
        {
                /* Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa eimprimir uma das mensagens: 
                se idade <= 13: Criança, se idade > 13 e <= 18:Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso*/

            Console.WriteLine("Exercicio 04");
            Console.WriteLine("Informe a sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            if (idade <=13){
                Console.WriteLine("Criança");
            }
                else if (idade >13 && idade <=18){
                    Console.WriteLine("Adolescente");
                }
                    else if (idade <=60){
                        Console.WriteLine("Adulto");
                    }
                        else {
                            Console.WriteLine("idoso");
                        }            

        }
    }
}