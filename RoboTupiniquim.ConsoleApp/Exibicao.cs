namespace RoboTupiniquim.ConsoleApp
{
    public static class Exibicao
    {

        public static void CadeiaDeComandos()
        {
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
            }
        }

        public static void MenuInicial()
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
        }


        public static void TamanhoGrid()
        {
            Console.WriteLine("Por favor, informe o tamanho do grid (coordenadas X): ");
            int gridX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, informe o tamanho do grid (coordenada Y): ");
            int gridY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
    }
}