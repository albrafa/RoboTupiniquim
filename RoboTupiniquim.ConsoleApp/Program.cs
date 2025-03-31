using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.IO.Compression;
using System.Runtime.Intrinsics.X86;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)

        // menu inicial
        {
            Exibicao.MenuInicial();

            Exibicao.TamanhoGrid();

            Exibicao.CadeiaDeComandos();

            Console.ReadLine();
        }
    }
}

                

   
     
    

