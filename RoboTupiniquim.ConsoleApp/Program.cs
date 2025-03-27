using System.ComponentModel.DataAnnotations;
using System.IO.Compression;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

            // menu inicial
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("           Robô Tupiniquim");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("  Y");
            Console.WriteLine("5 |");
            Console.WriteLine("4 |");            
            Console.WriteLine("3 |");
            Console.WriteLine("2 |");
            Console.WriteLine("1 |__.__.__.__.__ X");
            Console.WriteLine("    1  2  3  4  5");
            Console.WriteLine();
            Console.WriteLine("Você é o controlador do robô. Para movê-lo, utilize os seguintes comandos:");
            Console.WriteLine("E: você fará com que o robô vire para a ESQUERDA do seu eixo, mas sem se mover.");
            Console.WriteLine("D: você fará com que o robô vire para a DIREITA do seu eixo, mas sem se mover.");
            Console.WriteLine("M: você moverá o robô para onde ele estiver apontando naquele momento.");
            Console.WriteLine();

            // input: posição inicial / comandos

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
