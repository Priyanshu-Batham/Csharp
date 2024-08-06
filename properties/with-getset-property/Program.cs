/*
    Accessor name can be different from the variable name that they set the value into.
    Like in this prog, the variable name is _id but its setter is called id.
    while using the class we'll access these variables with the name of accessors only i.e "id" and not "_id"
 */
public class Student {
    private int _id;
    private string _name;
    private int _passmarks = 35;

    public int id
    {
        set
        {
            if (value < 0) throw new Exception("Id should be greater than 0");
            _id = value;
        }
        get
        {
            return _id;
        }
    }

    public string name
    {
        set
        {
            if (string.IsNullOrEmpty(value)) throw new Exception("Name shouldn't be empty");
            _name = value;
        }
        get
        {
            return _name;
        }
    }

    public int passmarks
    {
        get
        {
            return _passmarks;
        }
    }
}

class Program {
    static void Main(string[] args)
    {
        Student S = new Student();
        S.id = 101;
        S.name = "Priyanshu";
        
        Console.WriteLine("Student id={0}", S.id);
        Console.WriteLine("Student name={0}", S.name);
        Console.WriteLine("Student passmarks={0}", S.passmarks);

        Console.ReadKey();
    }
}
