//by default all members are private

class Constructors
{
    int a;

    //Default constructor
    public Constructors()
    {
        a = 10;
        Console.WriteLine("default constructor");
    }

    //Parameterised constructor
    public Constructors(int a)
    {
        this.a = a;
        Console.WriteLine("Parameterised constructor");
    }

    //Copy constructor
    public Constructors(Constructors obj)
    {
        this.a = obj.a;
        Console.WriteLine("Copy constructor");
    }

    //Private constructor
    private Constructors(int a, int b) { 
        this.a = a;
        Console.WriteLine("private constructor");
    }

    public static void privateConstructorInvoker()
    {
        Constructors obj = new Constructors(10, 20);
    }
}

class Prog
{
    public static void Main()
    {
        Constructors app = new Constructors();
        Constructors app1 = new Constructors(20);
        Constructors app2 = new Constructors(app1);
        Constructors.privateConstructorInvoker();
    }
}