using System;
using System.IO;

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
                case 1: OpenFile(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void OpenFile(){




            //Menu();
        }

        static void Edit(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-------------------");

            string text = "";
            do{
                text += Console.ReadLine();
                text += Environment.NewLine; // quebrando a linha no final de cada leitura
            }while(Console.ReadKey().Key != ConsoleKey.Escape); // enquanto a tecla for diferente de esc continuará o laço de repetição

            Console.Write(text);


            //Menu();
        }

        static void save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path)) //Cria uma nova instância de StreamWriter e a associa ao arquivo especificado pelo caminho path.
            {
                file.Write(text); //tudo o que precisa para salvar o arquivo
            }
        }
    }
}
