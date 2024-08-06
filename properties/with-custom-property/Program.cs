
public class Student
{
    private int _id;
    private string _name;
    private int _passmarks = 35;

    //Id accessors
    public void setId(int id)
    {
        if (id < 0) throw new Exception("Id should be greater than 0");
        this._id = id;
    }

    public int getId()
    {
        return this._id;
    }


    //name accessors
    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new Exception("Name should not be empty");
        this._name = name;
    }

    public string getName()
    {

        if (string.IsNullOrEmpty(this._name)) return "No Name";
        return this._name;
    }

    //passmark accessor

    public int getPassmarks()
    {
        return this._passmarks;
    }


}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.setId(101);
        s.setName("Priyanshu");
        Console.WriteLine("Student id={0}", s.getId());
        Console.WriteLine("Student name={0}", s.getName());
        Console.WriteLine("Student passmarks={0}", s.getPassmarks());

        Console.ReadKey();
    }
}