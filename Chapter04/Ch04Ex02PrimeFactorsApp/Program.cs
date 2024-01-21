using static System.Console;
using Ch04Ex02PrimeFactorsLib;

Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string primeFactors = PrimeFactors.GetPrimeFactors(number);
WriteLine($"Prime facots of {number} are: {primeFactors}");