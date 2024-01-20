// FizzBuzz Game - Exercise 3.4

for (int i = 1; i <= 100; i++)
{
    string number = (i % 3 == 0, i % 5 == 0) switch
    {
        (true, true) => "FizzBuzz",
        (true, false) => "Fizz",
        (false, true) => "Buzz",
        (false, false) => i.ToString(),
    };

    WriteLine(number);
}

