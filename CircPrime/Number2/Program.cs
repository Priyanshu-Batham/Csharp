class CircularPrime
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is a circular prime: ");
        int number = int.Parse(Console.ReadLine()!);

        bool isCircularPrime = IsCircularPrime(number);

        Console.WriteLine($"The number {number} is {(isCircularPrime ? "a circular prime" : "not a circular prime")}.");

        Console.WriteLine("Cyclic permutations:");
        PrintCyclicPermutations(number);
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    public static bool IsCircularPrime(int number)
    {
        string str = number.ToString();
        int length = str.Length;

        for (int i = 0; i < length; i++)
        {
            string perm = str.Substring(i) + str.Substring(0, i);
            if (!IsPrime(int.Parse(perm)))
            {
                return false;
            }
        }
        return true;
    }

    // generating cyclic permutations of a number
    public static void PrintCyclicPermutations(int number)
    {
        string str = number.ToString();
        int length = str.Length;

        for (int i = 0; i < length; i++)
        {
            string perm = str.Substring(i) + str.Substring(0, i);
            Console.WriteLine(perm);
        }
    }
}
