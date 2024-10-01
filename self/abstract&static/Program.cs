class Hi : Abs
{

    public void anything()
    {
        fun();
        int num = a;
        Console.WriteLine(num);
    }

    public static void Main(String[] args)
    {
        string str = "Priyanshu";
        Hi obj = new Hi();
        obj.anything();
    }
}

abstract class Abs
{
    public static int a = 10;
    public void fun()
    {
        System.Console.WriteLine(a);
    }
}
