class PractiseQus2
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse( Console.ReadLine() !);
  
        for (int i = 1; i < (num/2); i++)
        {
            if(isPrime(i) && isPrime(num - i))
            {
                Console.WriteLine(i+ " : "+ (num - i));
            }
        }

    }
    public static bool isPrime(int num)
    {
        if (num <= 2) return true;
        for (int i = 2; i * i < num+1; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}