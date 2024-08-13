class ArrayTwoDimension
{
    public static void Main()
    {
        /*int[,] this syntax is for 2D arrays where all subarrays are of equal length
         *int[][] this syntax is for jagged arrays where subarrays' lengths are different
         */
        //printTranspose(take2DInput(3, 2));
        print2DArray(rotateBy90(take2DInput(3, 2)));

    }

    //1) Take input a 2D array with specified dimensions
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

    //2) Prints a 2D array with specified dimension
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
        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
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
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
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
        for (int i = 0; i < arr.GetLength(0) && i < arr.GetLength(1); i++)
        {
            Console.WriteLine($"Element{i + 1}: {arr[i, i]}");
        }
    }

    //7) Print Boundary Values
    static void printBoundaryValues(int[,] arr)
    {
        //top
        Console.Write("Top: ");
        for (int i = 0; i < arr.GetLength(1); i++)
        {

            Console.Write($"{arr[0, i]}, ");
        }
        //Right
        Console.Write("Right: ");
        for (int i = 0; i < arr.GetLength(0); i++)
        {

            Console.Write($"{arr[i, arr.GetLength(1) - 1]}, ");
        }
        //Bottom
        Console.Write("Bottom: ");
        for (int i = 0; i < arr.GetLength(1); i++)
        {

            Console.Write($"{arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1 - i]}, ");
        }
        //Left
        Console.Write("Left: ");
        for (int i = 0; i < arr.GetLength(0); i++)
        {

            Console.Write($"{arr[arr.GetLength(0) - 1 - i, 0]}, ");
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
        int[,] matrix = new int[(arr.Length / (width + 1)) + 1, width];
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
        for (int i = 0; i < flatty.Length / 2; i++)
        {
            int temp = flatty[i];
            flatty[i] = flatty[flatty.Length - 1 - i];
            flatty[flatty.Length - 1 - i] = temp;
        }
        return deflattenArray(flatty, arr.GetLength(1));
    }

    //11) Print Transpose
    static void printTranspose(int[,] arr)
    {
        Console.WriteLine("\nTranspose of the matrix is:");
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                Console.Write(arr[j, i] + "\t");
            }
            Console.WriteLine();
        }
    }

    //12) Print saddle point if any
    static void findSaddlePoints(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            // Find the minimum element in the current row
            int rowMin = matrix[i, 0];
            int colIndex = 0;

            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] < rowMin)
                {
                    rowMin = matrix[i, j];
                    colIndex = j;
                }
            }

            // Check if the found minimum element is the maximum in its column
            bool isSaddlePoint = true;

            for (int k = 0; k < rows; k++)
            {
                if (matrix[k, colIndex] > rowMin)
                {
                    isSaddlePoint = false;
                    break;
                }
            }

            // If it is a saddle point, print it
            if (isSaddlePoint)
            {
                Console.WriteLine($"Saddle point found at row {i + 1}, column {colIndex + 1}: {rowMin}");
            }
        }
    }

    //13) Matrix Multiplication
    static int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        int rowsA = a.GetLength(0);
        int colsA = a.GetLength(1);
        int rowsB = b.GetLength(0);
        int colsB = b.GetLength(1);

        int[,] result = new int[rowsA, colsB];

        if (colsA != rowsB)
        {
            Console.Write("Invalid dimensions");
            return result;
        }


        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return result;
    }

    //14) Spiral Matrix
    static void PrintSpiralOrder(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int top = 0, bottom = rows - 1, left = 0, right = cols - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
                Console.Write(matrix[top, i] + " ");
            top++;

            for (int i = top; i <= bottom; i++)
                Console.Write(matrix[i, right] + " ");
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    Console.Write(matrix[bottom, i] + " ");
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    Console.Write(matrix[i, left] + " ");
                left++;
            }
        }
        Console.WriteLine();
    }

    //15) Rotate matrix by 90 degrees
    static int[,] rotateBy90(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        int[,] newArr = new int[cols, rows];

        for(int i = 0; i<cols; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                newArr[i, j] = arr[j, cols - 1 - i];
            }
        }

        return newArr;
    }

    //16) All values same in diagonal and all other values are 0
    public void scalar2d(int[,] arr)
    {
        int i, j;
        int dup = arr[0, 0];
        bool flag = true;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                if (i == j)
                {
                    if (arr[i, j] != dup && arr[i, j] != 0)
                    {
                        flag = false; break;
                    }
                }
                if (arr[i, j] != 0 && i != j)
                {
                    flag = false; break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Matrix is NOT Scalar Matrix");
                break;
            }
        }
        if (flag == true)
        {
            Console.WriteLine("Matrix is Scalar Matrix");
        }
    }

    //17) Diagonal 1 and all 0
    public void identity2d(int[,] arr)
    {
        int i, j;
        bool flag = true;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                if (i == j)
                {
                    if (arr[i, j] != 1)
                    {
                        flag = false; break;
                    }
                }
                if (arr[i, j] != 0 && i != j)
                {
                    flag = false; break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Matrix is NOT Identity Matrix");
                break;
            }
        }
        if (flag == true)
        {
            Console.WriteLine("Matrix is Identity Matrix");
        }
    }

    //18)
    public void square2d(int[,] arr)
    {
        int i, j;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write((arr[i, j] * arr[i, j]) + " ");
            }
            Console.WriteLine();
        }
    }

    //19)
    public void sparse2d(int[,] arr)
    {
        int i, j, count = 0;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == 0)
                    count++;
            }
        }
        if (count > ((arr.GetLength(0)*arr.GetLength(1))/2))
            Console.WriteLine("It is Sparse Matrix");
        else Console.WriteLine("It is NOT Sparse Matrix");
    }

    //20)
    public void sumDiagonal2d(int[,] arr)
    {
        int i, j;
        int sum = 0;
        for (i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                if (i == j)
                    sum += arr[i, j];
            }
        }
        Console.WriteLine("Sum of Diagonal elements: " + sum);
    }

}