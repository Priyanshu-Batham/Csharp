using c = System.Console;
class MyString
{
    public static void Main()
    {
        String str = "Abc";
        //accessing element through index
        c.WriteLine(str[0]);
        //accessing index through element
        c.WriteLine(str.IndexOf("A"));
        //for changing string create a new or replace method but not preferred
        c.WriteLine(str.Replace("A", "B"));

        //char to ascii code
        c.WriteLine((int)str[0]);
        //ascii code to char
        c.WriteLine((char)65);

        //can also do
        c.WriteLine(str[0] - 'A');
        c.WriteLine(str[0] - 0);
    }
}
