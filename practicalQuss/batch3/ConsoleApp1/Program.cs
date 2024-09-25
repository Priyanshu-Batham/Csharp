using c = System.Console;
class Practical { 

    //Ques 1
    internal void nearestVowel(out int vowelAt, out int charAt, char ch, string str)
    {
        vowelAt = -1;
        charAt = -1;
        int i;

        for(i = 0; i<str.Length; i++)
        {
            //if str[i] is a vowel
            if ("aeiouAEIOU".Contains(str[i]))
            {
                vowelAt = i;
                if (charAt != -1) return;
            }
            if (str[i] == ch)
            {
                charAt = i;
                if (vowelAt != -1) return;
            }
        }
    }

    //Ques 2
    internal void printFrequency(string str)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (var item in str)
        {
            if (map.ContainsKey(item)) map[item]++;
            else map[item] = 1;
        }

        foreach (var item in map)
        {
            c.WriteLine($"Letter: {item.Key} | Frequency: {item.Value}");
        }
    }

    //Ques 3

    internal void wordWithMaxVowels(string str, out string maxWord, out int count)
    {
        maxWord = "";
        count = 0;
        string[] words = str.Split();

        foreach (var item in words)
        {
            int itemCountVowel = item.countVowels();
            if (itemCountVowel > count)
            {
                maxWord = item;
                count = itemCountVowel;
            }
        }
    }

}

//How to add own methods to existing classes, since in C# we the predefined classes are sealed and we cannot inherit them to add our stuff :(
public static class StringExtensions //class must be static
{
    //methods must be static since class is static
    public static int countVowels(this string str) //datatype followed by "this" keyword is the class whose extension is performed. We can only pass one variable.
    {
        int count = 0;
        foreach (var item in str) if ("aeiouAEIOU".Contains(item)) count++;
        return count;
    }
}

class Execute
{
    public static void Main()
    {
        string str = "Hello how are you";
        char ch = 'r';

        Practical test = new Practical();

        //Ques 1
        c.WriteLine("Ques 1");
        int vowelAt, charAt;
        test.nearestVowel(out vowelAt, out charAt, ch, str);
        if (charAt != -1 || vowelAt != -1)
        {
            c.WriteLine($"{ch} in {str} is found at index {charAt} and the nearest vowel '{str[vowelAt]}' is found at index {vowelAt}");
        }
        c.WriteLine();

        //Ques 2
        c.WriteLine("Ques 2");
        test.printFrequency(str);
        c.WriteLine();

        //Ques 3
        c.WriteLine("Ques 3");
        string maxWord;
        int countOfVowels;
        test.wordWithMaxVowels(str,out maxWord, out countOfVowels);
        c.WriteLine($"Word with max vowels is: {maxWord} with a count of {countOfVowels}");
    }
}
