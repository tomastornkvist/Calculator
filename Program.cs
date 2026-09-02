static int ReadOperator()
{
    int op;


    Console.Write("Räknesätt (+ - * / % =): ");

    while (!int.TryParse(Console.ReadLine(), out op))
        Console.Write("Du måste ange ett giltigt räknesätt (+ - * / % =): ");

    return op;
}

static double ReadNumber()
{
    double number;


    Console.Write("Tal: ");

    while (!double.TryParse(Console.ReadLine(), out number))
        Console.Write("Du måste ange ett giltigt tal: ");

    return number;
}

