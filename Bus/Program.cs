class Bus
{
    bool[,] seats;
    int emptySeats;
    int totalSeats;
    int noOfPassangers; //also works as an index for matrix

    //initializing the bus
    Bus(int x, int y)
    {
        this.seats = new bool[x, y];
        this.noOfPassangers = 0;
        this.totalSeats = x * y;
        this.emptySeats = totalSeats;
    }

    //view the bus
    void viewBus()
    {
        Console.WriteLine($"Total Seats: {this.totalSeats}  Empty Seats: {this.emptySeats}  Passangers: {this.noOfPassangers}");
        for(int i = 0; i< this.seats.GetLength(0); i++)
        {
            for(int j = 0; j< this.seats.GetLength(1); j++)
            {
                if (this.seats[i, j] == true) Console.Write("1 ");
                else Console.Write("0 ");
            }
            Console.WriteLine();
        }
    }

    //returns false if not enough space else true
    bool enterPassangers(int incomingPassangers)
    {
        if (incomingPassangers > this.emptySeats) return false;
        else
        {
            this.emptySeats -= incomingPassangers;
            for(int i = 0; i<incomingPassangers; i++)
            { 
                this.seats[this.noOfPassangers / this.seats.GetLength(1), this.noOfPassangers % this.seats.GetLength(1)] = true;
                this.noOfPassangers++;
            }
        }
        return true;
    }

    public static void Main()
    {
        Bus bus = new Bus(7, 5);
        //Printing CLI interface
        while (true)
        {
            Console.WriteLine("1: View Bus");
            Console.WriteLine("2: Enter Passangers");
            Console.WriteLine("3: Exit");
            Console.Write("Enter: ");

            int menuChoice = int.Parse(Console.ReadLine() !);
            if(menuChoice == 1)
            {
                bus.viewBus();
            }
            else if(menuChoice == 2)
            {
                Console.Write("How many Passangers to enter?");
                int noOfPassangers = int.Parse(Console.ReadLine() !);
                bool result = bus.enterPassangers(noOfPassangers);
                if (!result) Console.WriteLine("Not Enough space in Bus");
                else Console.WriteLine("Passangers entered Successfully");
            }
            else if(menuChoice == 3)
            {
                Console.WriteLine("ThankYou");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}