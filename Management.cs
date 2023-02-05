using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public static class Management
    {
        public static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (StreamReader file = new(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();

            //Menu();
        }

        public static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (Pressione ESC para sair)");
            Console.WriteLine("-------------------------------------------------");

            StringBuilder text = new();

            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save.Salvar(text.ToString());
        }
    }
}
