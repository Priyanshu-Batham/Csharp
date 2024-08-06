/*
    Warning is because we are assigning null to name variable which is a non nullable datatype. 
    Reference types are non-nullable by default (not sure).
 */

public class Student
{
    public int id;
    public string name;
    public int passmark;
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.id = -100;
        s.name = null;
        s.passmark = 0;

        Console.WriteLine("id={0} && name={1} && passmark={2}", s.id, s.name, s.passmark);

        Console.ReadKey();
    }
}