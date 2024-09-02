using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch(option){
                case 0: System.Environment.Exit(0); break;
                case 1: OpenArq(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void OpenArq(){




            Menu();
        }

        static void Edit(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-------------------");

            string text = "";
            while(Console.ReadKey().Key != ConsoleKey.Escape){ // enquanto a tecla for diferente de esc continuará o laço de repetição
                
            }


            Menu();
        }
    }
}
