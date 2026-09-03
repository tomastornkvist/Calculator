// Reads a number from the commandline and makes sure it's a valid double
static double ReadNumber(string prompt, bool noZero)
{
    double number;

    Console.Write(prompt);

    while (!double.TryParse(Console.ReadLine(), out number) || (noZero && number == 0))
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
        op = Console.ReadLine();
        if (op != null && op.Length == 1 && "+-*/%=".Contains(op))
            correct = true;
        else
            Console.Write("Du måste ange ett giltigt räknesätt (+ - * / % =): ");
    } while (!correct);

    return op!;
}

string op;
double currentResult = ReadNumber("Tal: ", false);

do
{
    op = ReadOperator();

    if (op != "=")
    {
        double number = ReadNumber("Tal: ", op == "/");

        switch (op)
        {
            case "+":
                currentResult += number;
                break;

            case "-":
                currentResult -= number;
                break;

            case "*":
                currentResult *= number;
                break;

            case "/":
                currentResult /= number;
                break;

            case "%":
                currentResult %= number;
                break;
        }
        Console.WriteLine($"= {currentResult}");
    }

} while (!op.Equals("="));

Console.WriteLine($"Slutresultat: {currentResult}");

