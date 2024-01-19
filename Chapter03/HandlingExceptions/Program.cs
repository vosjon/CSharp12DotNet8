﻿// SeWriteLine("Before parsing"); 
Write("What is your age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
/*catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}*/


/*catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}*/

WriteLine("After parsing");

checked
{
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
}
