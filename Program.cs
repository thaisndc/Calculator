/// Practicing...
/// Balta.io Class

Menu();

void Menu()
{
    Console.Clear();

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1 - Sum");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");
    Console.WriteLine("5 - Exit");

    Console.WriteLine("-------------");
    Console.WriteLine("Select an option: ");

    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Sum(); break;
        case 2: Subtract(); break;
        case 3: Divide(); break;
        case 4: Multiply(); break;
        case 5: Environment.Exit(0); break;
        default: Menu(); break;
    }
}

void Sum()
{
    Console.Clear();

    Console.WriteLine("First value: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float result = v1 + v2;
    Console.WriteLine($"The result of the sum is {result}");
    Console.ReadKey();
    Menu();
}

void Subtract()
{
    Console.Clear();

    Console.WriteLine("First value:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float result = v1 - v2;
    Console.WriteLine($"The result of the subtraction is {result}");
    Console.ReadKey();
    Menu();
}

void Divide()
{
    Console.Clear();

    Console.WriteLine("First value:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float result = v1 / v2;
    Console.WriteLine($"The result of the division is {result}");
    Console.ReadKey();
    Menu();
}

void Multiply()
{
    Console.Clear();

    Console.WriteLine("First value:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value:");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float result = v1 * v2;
    Console.WriteLine($"The result of the multiplication is {result}");
    Console.ReadKey();
    Menu();
}
