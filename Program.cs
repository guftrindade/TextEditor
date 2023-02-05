using TextEditor;

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
        case 1: Management.Abrir(); break;
        case 2: Management.Criar(); break;
    }
}


