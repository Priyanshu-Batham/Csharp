using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // 20x10 char matrix representing a dog
        char[,] matrix = new char[10, 20]
         {
            {' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '}
         };

        double angle = 0; // Start angle in radians

        while (true)
        {
            Console.Clear();  // Clear the console for each frame

            // Apply rotation to the matrix and render
            RenderMatrix(RotateMatrix(matrix, angle));

            // Increment the angle for smooth rotation (small increments)
            angle += Math.PI / 180; // Rotate by 1 degree each iteration

            // Delay for visibility
            Thread.Sleep(100); // 100 milliseconds delay for smooth animation
        }
    }

    static void RenderMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static char[,] RotateMatrix(char[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        char[,] rotatedMatrix = new char[rows, cols];

        // Center of the matrix (rotation origin)
        double cx = cols / 2.0;
        double cy = rows / 2.0;

        // Rotation matrix elements
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        // Apply the 2D rotation transformation
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Calculate coordinates relative to the center
                double x = j - cx;
                double y = i - cy;

                // Rotate using the 2D rotation matrix
                int newX = (int)(x * cosTheta - y * sinTheta + cx);
                int newY = (int)(x * sinTheta + y * cosTheta + cy);

                // Check bounds and map to rotated matrix
                if (newX >= 0 && newX < cols && newY >= 0 && newY < rows)
                {
                    rotatedMatrix[newY, newX] = matrix[i, j];
                }
            }
        }

        // Fill empty spaces with blank spaces
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (rotatedMatrix[i, j] == '\0')
                {
                    rotatedMatrix[i, j] = ' ';
                }
            }
        }

        return rotatedMatrix;
    }
}
