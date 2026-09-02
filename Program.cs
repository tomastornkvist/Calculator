// Reads a number from the commandline and makes sure it's a valid double
static double ReadNumber()
{
    double number;

    Console.Write("Tal: ");

    while (!double.TryParse(Console.ReadLine(), out number))
        Console.Write("Du måste ange ett giltigt tal: ");

    return number;
}

// Reads an operator from the commandline and makes sure it's one of +, -, *, /, % or =.
static string ReadOperator()
{
    string? op;
    bool correct = false;


    Console.Write("Räknesätt (+ - * / % =): ");

    do
    {
        switch (op = Console.ReadLine())
        {
            case "+":
            case "-":
            case "*":
            case "/":
            case "%":
            case "=":
                correct = true;
                break;

            default:
                Console.Write("Du måste ange ett giltigt räknesätt (+ - * / % =): ");
                break;
        }
    } while (!correct);

    return op!;
}

string op;
double currentResult = ReadNumber();

do
{
    op = ReadOperator();

    if (op != "=")
    {
        double number = ReadNumber();

        switch (op)
        {
            case "+":
                currentResult += number;
                Console.WriteLine($"= {currentResult}");
                break;

            case "-":
                currentResult -= number;
                Console.WriteLine($"= {currentResult}");
                break;

            case "*":
                currentResult *= number;
                Console.WriteLine($"= {currentResult}");
                break;

            case "/":
                currentResult /= number;
                Console.WriteLine($"= {currentResult}");
                break;

            case "%":
                currentResult %= number;
                Console.WriteLine($"= {currentResult}");
                break;
        }
    }

} while (!op.Equals("="));

Console.WriteLine($"Slutresultat: {currentResult}");

