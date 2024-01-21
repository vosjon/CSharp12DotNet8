namespace Ch04Ex02PrimeFactorsLib;

public class PrimeFactors
{
    public static string GetPrimeFactors(int number)
    {
        List<int> factors = CalculatePrimeFactors(number);
        return string.Join(" x ", factors.Select(x => x.ToString()));
    }

    private static List<int> CalculatePrimeFactors(int number)
    {
        List<int> factors = new List<int>();

        while (number % 2 == 0)
        {
            factors.Add(2);
            number /= 2;
        }

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            while (number % i == 0)
            {
                factors.Add(i);
                number /= i;
            }
        }

        if (number > 2)
        {
            factors.Add(number);
        }

        return factors;
    }
}
