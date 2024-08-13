using myLibrary;

class Prog
{
    public static void Main()
    {
        MyStringFuns app = new();
        Console.WriteLine(app.reverseString("abc"));
        Console.WriteLine(app.areAnagrams("abc", "bca"));
        Console.WriteLine(app.complement(23));
        Console.WriteLine(app.add6(63));
        Console.WriteLine(app.isPallindrome("madam"));
        Console.WriteLine(app.isValidEmail("priyanshu@gmail.com"));
        Console.WriteLine(app.removeDuplicates("a a a a ab b b b c"));
    }
}