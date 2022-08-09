using System;
namespace ListaExercicio
{
    class Exe01
    {       //Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule asua área
        public static void renderizar()
        {
            Console.WriteLine("Exercicio 01");

            Console.WriteLine("Digite a altura: ");
                            //readline == lê o dado que foi passado na linha de cima, armazenando em forma de string
            int altura = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite a largura: ");
                            //Int32.Parse == converte apenas String para int, o 32 significa que vai até certo limite de números, podendo ser 16,32,64
                            //O método Convert.To == converte de qualquer tipo para qualquer tipo
            int largura = Int32.Parse(Console.ReadLine());
            int area = altura * largura;
            // Console.WriteLine("A area é : " + area);
                            //Ao colocar o simbolo $ antes, e colocar a variavel em {}, voce evita consumir dados da maquina usando o + 
            Console.WriteLine($"A area é : { area }");
        }
    }
}