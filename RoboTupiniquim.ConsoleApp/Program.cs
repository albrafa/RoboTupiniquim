using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
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

            // input: GRID

            Console.WriteLine("Por favor, informe o tamanho do grid (coordenadas X): ");
            int gridX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, informe o tamanho do grid (coordenada Y): ");
            int gridY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // input: posição inicial

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Por favor, informe a coordenada inicial 'X' do robô.");
                int xStartingPoint = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Por favor, informe a coordenada inicial 'Y' do robô.");
                int yStartingPoint = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                char facingDirection;
                Console.WriteLine("Por favor, informe a direção inicial do robô.");
                facingDirection = char.Parse(Console.ReadLine());

                int[] initialPosition = { xStartingPoint, yStartingPoint };

                int x = initialPosition[0];
                int y = initialPosition[1];

                //Console.WriteLine($"As coordenadas iniciais do robô são: {initialPosition}. Informe o próximo comando...");
                //Console.ReadLine();

                //for (int x = 0; x < gridX; x++)
                //{
                //    Console.Write($"O robô se encontra na coordenada X{x},");
                //}

                //for (int y = 0; y < gridY; y++)
                //{
                //    Console.Write($"e na coordenada Y{y}. Informe o próximo comando...");
                //}

                // comandos

                Console.WriteLine("Informe o próximo comando...");
                string commands = Console.ReadLine();


                for (int j = 0; j < commands.Length; j++)

                {

                    switch (commands[j])
                    {
                        case 'E':
                            if (facingDirection == 'N')
                            {
                                facingDirection = 'O';
                            }
                            else if (facingDirection == 'O')
                            {
                                facingDirection = 'S';
                            }
                            else if (facingDirection == 'S')
                            {
                                facingDirection = 'L';
                            }
                            else if (facingDirection == 'L')
                            {
                                facingDirection = 'N';
                            }
                            break;

                        case 'D':
                            {
                                if (facingDirection == 'N')
                                {
                                    facingDirection = 'L';
                                }
                                else if (facingDirection == 'L')
                                {
                                    facingDirection = 'S';
                                }
                                else if (facingDirection == 'S')
                                {
                                    facingDirection = 'O';
                                }
                                else if (facingDirection == 'O')
                                {
                                    facingDirection = 'N';
                                }
                                break;

                            }
                        case 'M':
                            {
                                if (facingDirection == 'N')
                                {
                                    y++;
                                }

                                else if (facingDirection == 'S')
                                {
                                    y--;
                                }
                                else if (facingDirection == 'L')
                                {
                                    x++;
                                }
                                else if (facingDirection == 'O')
                                {
                                    x--;
                                }
                                break;
                            }
                    }


                }
                Console.WriteLine($"O robô parou nas coordenadas X{x} e Y{y} e apontando para {facingDirection}.");
                Console.ReadLine();
            }
            
            
        }

    }

}
                

   
     
    

