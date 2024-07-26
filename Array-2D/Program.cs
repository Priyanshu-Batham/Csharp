
class ArrayTwoDimension
{
    public static void Main()
    {
        /*int[,] this syntax is for 2D arrays where all subarrays are of equal length
         *int[][] this syntax is for jagged arrays where subarrays' lengths are different
         */
        print2DArray(reverse(take2DInput(2, 2)));
    }

    //1) Take user input
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

    //2) Print the 2D array
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

    //3) Sum of 2 Matrices with same dimensions
    static int[,] sumOfMatricesWithSameDimensions(int[,] x, int[,] y)
    {
        int[,] z = new int[x.GetLength(0), x.GetLength(1)];
        for(int i = 0; i<x.GetLength(0); i++)
        {
            for(int j = 0; j<x.GetLength(1); j++)
            {
                z[i, j] = x[i, j] + y[i, j];
            }
        }
        return z;
    }

    //4) Flatten a Matrix
    static int[] flattenMatrix(int[,] arr)
    {
        int[] newArr = new int[arr.GetLength(0) * arr.GetLength(1)];
        int ctr = 0;
        for(int i = 0; i<arr.GetLength(0); i++)
        {
            for(int j = 0;j<arr.GetLength(1); j++)
            {
                newArr[ctr++] = arr[i, j];
            }
        }
        return newArr;
    }

    //5) Sum of all elements of a matrix
    static int sumOfElements(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }

    //6) Print Diagonal
    static void printDiagonal(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0) && i<arr.GetLength(1); i++)
        {
            Console.WriteLine($"Element{i + 1}: {arr[i, i]}");
        }
    }

    //7) Print Boundary Values
    static void printBoundaryValues(int[,] arr)
    {
        //top
        Console.Write("Top: ");
        for(int i = 0; i<arr.GetLength(1); i++)
        {

            Console.Write($"{arr[0, i]}, ");
        }
        //Right
        Console.Write("Right: ");
        for(int i = 0; i<arr.GetLength(0); i++)
        {

            Console.Write($"{arr[i, arr.GetLength(1)-1]}, ");
        }
        //Bottom
        Console.Write("Bottom: ");
        for(int i = 0; i<arr.GetLength(1); i++)
        {

            Console.Write($"{arr[arr.GetLength(0)-1, arr.GetLength(1)-1-i]}, ");
        }
        //Left
        Console.Write("Left: ");
        for(int i = 0; i<arr.GetLength(0); i++)
        {

            Console.Write($"{arr[arr.GetLength(0)-1-i, 0]}, ");
        }
    }

    //8) checks if all elements in the array are even or not
    static bool isEvenMatrix(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] % 2 != 0) return false;
            }
        }
        return true;
    }

    //9) Deflatten Array
    static int[,] deflattenArray(int[] arr, int width)
    {
        //Console.Write(arr.Length);
        int[,] matrix = new int[(arr.Length/(width+1))+1, width];
        //Console.WriteLine($"{(arr.Length/(width+1))+1}, {width}");
        for (int i = 0; i < arr.Length; i++)
        {
            matrix[i / width, i % width] = arr[i];
        }
        return matrix;
    }

    //10) Reverse the matrix
    static int[,] reverse(int[,] arr)
    {
        int[] flatty = flattenMatrix(arr);
        for(int i = 0; i< flatty.Length / 2; i++)
        {
            int temp = flatty[i];
            flatty[i] = flatty[flatty.Length - 1 - i];
            flatty[flatty.Length - 1 - i] = temp;
        }
        return deflattenArray(flatty, arr.GetLength(1));
    }
}