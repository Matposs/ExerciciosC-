using System;
namespace ListaExercicio
{
    class Exe03
    {
        public static void renderizar ()
        {   
                /* Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior */

            Console.WriteLine("Exercicio 03");
            Console.WriteLine("Informe o primeiro número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1 > num2){
                Console.WriteLine($"O número maior é: {num1}");  
            }
                else if (num2 > num1){
                    Console.WriteLine($"O número maior é: {num2}");
                }
                    else {
                        Console.WriteLine("Os números são iguais");
                    }

        }
    }
}