//Single Inheritence

class Parent1
{
    int x, y;

    //Parent Constructor
    public Parent1()
    {
        this.x = 10;
        this.y = 20;
    }
    public void printing()
    {
        Console.WriteLine($"{this.x}, {this.y}");
    }
}

class Child1 : Parent1{
    //Default Child Constructor is automatically made and Parent Constructor is also called automatically
     public void printIt()
    {
        base.printing();
    }
}

//Multi Level Inheritence
class Child2:Child1{
    public void child2InheritingChild1()
    {
        base.printIt();
        Console.WriteLine("Child2 Inheriting Child1");
    }
}

//Multiple Inheritence   
  //--abstract class
abstract class AbstractClass
{
    public abstract void abstractFun();
}
  //--interface 
interface MyInterface
{
    public abstract void myInterfaceFun();
}
interface MyInterface2
{
    public abstract void myInterfaceFun2();
}
class InheritingMultipleClass : AbstractClass, MyInterface, MyInterface2
{
    override public void abstractFun()
    {
        Console.WriteLine("Abstract function");
    }

    public void myInterfaceFun()
    {
        Console.WriteLine("My interface fun");
    }
    public void myInterfaceFun2()
    {
        Console.WriteLine("My interface fun2");
    }
}

class MainProg {
    public static void Main()
    {
        InheritingMultipleClass obj = new InheritingMultipleClass();
        obj.abstractFun();
        obj.myInterfaceFun();
        obj.myInterfaceFun2();
    }
}