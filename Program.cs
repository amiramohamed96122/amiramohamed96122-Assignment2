while (true)
{
    Console.WriteLine("===== Calculator =====");

    Console.Write("Enter first number: ");
    double num1;

    if (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Error: Please enter a valid number.");
        continue;
    }

    Console.Write("Enter second number: ");
    double num2;

    if (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Error: Please enter a valid number.");
        continue;
    }

    Console.Write("Enter operation (+, -, *, /): ");
    string? operation = Console.ReadLine();

    switch (operation)
    {
        case "+":
            Console.WriteLine($"Result: {num1 + num2}");
            break;

        case "-":
            Console.WriteLine($"Result: {num1 - num2}");
            break;

        case "*":
            Console.WriteLine($"Result: {num1 * num2}");
            break;

        case "/":
            if (num2 == 0)
                Console.WriteLine("Error: Cannot divide by zero.");
            else
                Console.WriteLine($"Result: {num1 / num2}");
            break;

        default:
            Console.WriteLine("Invalid operation!");
            break;
    }

    Console.Write("Do you want another calculation? (y/n): ");

    if (Console.ReadLine()?.ToLower() != "y")
        break;

    Console.Clear();
}