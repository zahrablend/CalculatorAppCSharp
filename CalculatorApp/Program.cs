int num1, num2;
int result;

Console.WriteLine("Enter the first number:");
string userNum1 = Console.ReadLine().Trim();

Console.WriteLine("Enter the second number:");
string userNum2 = Console.ReadLine().Trim();

Console.WriteLine("Choose an operation: +, -, *, /");
string op = Console.ReadLine().Trim();

bool isNum1 = int.TryParse(userNum1, out num1);
bool isNum2 = int.TryParse(userNum2, out num2);

if (!isNum1 || !isNum2)
{
    Console.WriteLine("Error: You should have entered 2 numbers and an operation symbol!");
}
else
{
    if (num1 == 0 && op == "/")
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
    else
    {
        switch (op)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
                break;
            default:
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                break;
        }
    }

}

Console.ReadKey();

