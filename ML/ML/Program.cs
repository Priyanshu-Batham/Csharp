class ML
{
    int[] x;
    int[] y;
    int n;

    ML(int n)
    {
        this.n = n;
        Console.WriteLine("Enter x variables: ");
        this.x = this.takeArr();
        Console.WriteLine("Enter y variables: ");
        this.y = this.takeArr();
    }
    int[] takeArr()
    {
        int[] arr = new int[this.n];
        Console.WriteLine($"Enter {this.n} elements");
        for (int i = 0; i < this.n; i++)
        {
            Console.Write("Enter: ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        return arr;
    }

    int getIndex(int x)
    {
        for(int i = 0; i<this.n; i++)
        {
            if (this.x[i] >= x) return i;
        }
        return this.n - 1;
    }

    int predict(int xToPredict)
    {
        int index = this.getIndex(xToPredict);
        if (index == 0) return this.y[0];
        else if (this.x[index] == xToPredict) return this.y[index];
        else return (this.y[index] + this.y[index - 1]) / 2;
    }

    public static void Main()
    {
        ML obj = new ML(2);

        Console.WriteLine("enter value to predict: ");
        int xToPredict = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Prediction: " + obj.predict(xToPredict));
    }
}