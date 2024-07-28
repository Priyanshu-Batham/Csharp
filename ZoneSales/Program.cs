class ZoneSaleAnalyzer
{
    int[,] salesData;
    int[] totalSales;

    //Constants
    string[] zones = { "North", "East", "West", "South" };
    string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    string[] ranks = { "A", "B", "C", "D" };

    ZoneSaleAnalyzer()
    {
        //Rows = Jan - Dec (12)
        //Cols = North, East, West, South (4)
        this.salesData = new int[12, 4];
        this.totalSales = new int[4];
    }

    void fillData()
    {
        for (int i = 0; i < zones.Length; i++)
        {
            Console.WriteLine($"Enter the Sales Data for {zones[i]} zone");
            for (int j = 0; j < months.Length; j++)
            {
                Console.Write($"{months[j]}: ");
                salesData[j, i] = int.Parse(Console.ReadLine() !);
            }
        }
    }

    void calculateTotalSales()
    {
        //calculating total sales
        for (int i = 0; i < zones.Length; i++)
        {
            for (int j = 0; j < months.Length; j++)
            {
                totalSales[i] += salesData[j, i];
            }
        }
    }

    void sortData()
    {
        //Sorting totalSales and zones array in Descending Order
        for (int i = 0; i < totalSales.Length - 1; i++)
        {
            for (int j = i + 1; j < totalSales.Length; j++)
            {
                if (totalSales[i] < totalSales[j])
                {
                    //swap totalSales element
                    int temp = totalSales[i];
                    totalSales[i] = totalSales[j];
                    totalSales[j] = temp;

                    //swap zone element
                    string zone = zones[i];
                    zones[i] = zones[j];
                    zones[j] = zone;
                }
            }
        }
    }

    void printChart()
    {
        //printing final chart with Ranks
        Console.WriteLine("<<------------Performance Chart------------>>");
        Console.WriteLine("SNo  Zone  Rank  TotalSales");
        for(int i = 0;i <4; i++)
        {
            Console.WriteLine($"{i+1}    {zones[i]}    {ranks[i]}    {totalSales[i]}");
        }
        Console.WriteLine("<<----------------------------------------->>");
    }

    public static void Main()
    {
        ZoneSaleAnalyzer app = new ZoneSaleAnalyzer();
        app.fillData();
        app.calculateTotalSales();
        app.sortData();
        app.printChart();
    }
}