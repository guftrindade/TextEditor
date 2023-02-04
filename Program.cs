using System.Text;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Escolha uma Opção:");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar um novo arquivo");
    Console.WriteLine("0 - Sair");

    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Criar(); break;
    }
}

static void Abrir()
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
    Menu();
}

static void Criar()
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

    Salvar(text.ToString());
}

static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine("Informe o nome do arquivo abaixo: ");

    var name = Console.ReadLine();
    name = $"{name}_{DateTime.Now.Hour}";

    string path = $"d://cursos//{name}.txt";

    using(StreamWriter file = new(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo salvo em {path} ");
    Console.ReadLine();
    Menu();
}