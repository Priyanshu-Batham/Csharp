class ArrayTwoDimension
{
    public static void Main()
    {
        /*int[,] this syntax is for 2D arrays where all subarrays are of equal length
         *int[][] this syntax is for jagged arrays where subarrays' lengths are different
         */
        print2DArray(take2DInput(2, 2));
    }

    static int[,] take2DInput(int x, int y)
    {
        int[,] arr = new int[x,y];
        Console.WriteLine($"Input values in a {x}x{y} Array");

        for(int i = 0; i<x; i++)
        {
            for(int j = 0; j<y; j++)
            {
                Console.Write($"Element({i}, {j}): ");
                arr[i, j] = int.Parse(Console.ReadLine() !);
            }
        }

        return arr;
    }

    static void print2DArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]}, ");
            }
            Console.WriteLine("]");
        }
    }
}