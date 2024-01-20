// Exercise 3.5 - Execption Handling

try
{
    Write("Enter a number between 0 and 255: ");
    int num1 = Convert.ToInt32(ReadLine());

    Write("Enter another number between 0 and 255: ");
    int num2 = Convert.ToInt32(ReadLine());

    WriteLine($"{num1} divided by {num2} is {num1 / num2}");
}
catch (FormatException)
{
    WriteLine("Format Exeption: Input string was not the correct format.");
}