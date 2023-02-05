namespace TextEditor
{
    public static class Save
    {
        public static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do arquivo: ");

            var name = Console.ReadLine();

            string path = SetDefaultPath(name);

            using (StreamWriter file = new(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo em {path} ");
            Console.ReadLine();
        }

        static string SetDefaultPath(string name)
        {
            return $"d://cursos//{SetDefaultName(name)}.txt";
        }

        static string SetDefaultName(string name)
        {
            return $"{name}_{SetDateNow()}";
        }

        static string SetDateNow()
        {
            return string.Format("{0:dd_MM_yyyy_hh_mm_ss}", DateTime.Now);
        }
    }
}
