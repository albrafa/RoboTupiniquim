﻿using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Runtime.Intrinsics.X86;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        // Assuma que mover o robô para frente, significa mover sua posição de (X, Y)
        // para(x, y+1). por exemplo, um robô na posição(0,0) com a face para o norte,
        // ao se mover uma posição, vai parar em (0,1).

        //        Entrada
        //O programa deve possuir os seguintes parâmetros:
        //● A primeira linha deve ser as coordenadas do canto superior direito da
        //área.O canto inferior esquerdo é sempre(0,0).
        //● O resto das entradas deve ser os comandos que o robô deve executar.
        //Cada comando deve ser enviado em 2 partes: a primeira parte é a
        //posição inicial do robô e a segunda uma série de instruções que aquele
        //robô deve seguir para explorar a área.
        //A posição é dada com 2 inteiros e uma letra, separados por espaços,
        //correspondendo pelas coordenadas X e Y e a orientação do robô.Cada robô
        //vai executar as instruções de forma sequencial: o segundo robô só iniciará
        //suas ações quando o primeiro terminar.

        static void Main(string[] args)

            // menu inicial
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("           Robô Tupiniquim");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Olá, e seja bem-vindo ao programa Robô Tupiniquim da AEB. Você precisará guiar o robô através das");
            Console.WriteLine("câmeras acopladas nele. É importante informar que o robô irá se mover em uma superfície retangular,");
            Console.WriteLine("sobre as quais você o guiará. Para efeitos de localização, o robô se moverá nas coordenadas X e Y, além de");
            Console.WriteLine("receber uma letra que informará a direção para onde o robô estará olhando.");
            Console.WriteLine();
            Console.WriteLine("Como você é o controlador do robô, é importante que você memorize os seguintes comandos:");
            Console.WriteLine("E: você fará com que o robô vire para a ESQUERDA do seu eixo, mas sem se mover.");
            Console.WriteLine("D: você fará com que o robô vire para a DIREITA do seu eixo, mas sem se mover.");
            Console.WriteLine("M: você moverá o robô para onde ele estiver apontando naquele momento.");
            Console.WriteLine();

            // input: posição inicial / GRID / comandos

            int positionX = 1;
            int positionY = 2;
            string facingDirection = "N";

            string commands = "EMEMEMEMM";


            for (int i = 0; i < commands.Length; i++)
                        
            {
                if (commands[i] == 'E')
                {
                    facingDirection = "O";
                    if (commands[i] == 'E' && facingDirection == "O")
                    {
                        facingDirection = "S";
                        if (commands[i] == 'E' && facingDirection == "S")
                        {
                            facingDirection = "L";
                            if (commands[i] == 'E' && facingDirection == "L")
                            {
                                facingDirection = "N";
                            }
                        }
                    }

                }
                else if (commands[i] == 'D')
                {
                    facingDirection = "L";
                    if (commands[i] == 'D' && facingDirection == "L")
                    {
                        facingDirection = "S";
                        if (commands[i] == 'D' && facingDirection == "S")
                        {
                            facingDirection = "O";
                            if (commands[i] == 'D' && facingDirection == "O")
                            {
                                facingDirection = "N";
                            }
                        }
                    }
                }

            }


            // plano cartesiano + movimentação



            Console.ReadLine();
        }
    }
}
