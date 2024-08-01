using System.Security.Cryptography.X509Certificates;

class StringFuns
{
    //This class contains reusable methods that takes strings and params and returns modified strings
    //I'll only make the Main class for testing the functions as its not needed here
    public static void Main()
    {
        StringFuns app = new StringFuns();
        ArrangeLetters.arrange("BaSIca");
    }

    //1)
    string centerHeading(string str)
    {
        str = str.PadLeft(str.Length + 20, '-');
        str = str.PadRight(str.Length + 20, '-');
        str = str.PadLeft(str.Length + 3, '<');
        str = str.PadRight(str.Length + 3, '>');
        return str;
    }

    //2)
    bool isValidEmail(string str)
    { 
        if (!str.Contains('@') || !str.Contains('.')) return false;
        return true;
    }

    //3)
    string reverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    //4)
    bool isPallindrome(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        
        return str.Equals(new string(charArray));
    }

    //5)
    int countVowels(string str)
    {
        int vowels = 0;
        foreach (char c in str.ToLower())
        {
            if ("aeiou".Contains(c))
                vowels++;
        }
        return vowels;
    }

    //6)
    string removeDuplicates(string str)
    {
        string result = "";
        foreach (char c in str)
        {
            if (!result.Contains(c))
                result += c;
        }
        return result;
    }

    //7)
    void findAllSubstrings(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j <= str.Length; j++)
            {
                Console.WriteLine(str.Substring(i, j - i));
            }
        }
    }

    //8)
    string findLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longest = "";
        foreach (string word in words)
        {
            if (word.Length > longest.Length)
                longest = word;
        }
        return longest;
    }

    //9)
    int countWords(string str)
    {
        //we can pass a whole array of chars to determine the splitter
        //remove empty entries is done to get rid of duplicate empty spaces
        string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    //10)
    bool areAnagrams(string str1, string str2)
    {
        char[] charArray1 = str1.ToLower().ToCharArray();
        char[] charArray2 = str2.ToLower().ToCharArray();
        Array.Sort(charArray1);
        Array.Sort(charArray2);

        //Equals function wasn't working here :(
        return charArray1.SequenceEqual(charArray2);
    }

    // <<<<<-------------------------------1/Aug/24: Making C progs from w3resources--------------------->>>>>>

    //1) Write a C prog to sort a string array in asc order
    string sortString(string str)
    {
        //removing white spaces
        str = str.Replace(" ", "");

        //converting string to a charArr
        char[] charArr = str.ToCharArray();


        //performing selection sort
        for(int i = 0; i<charArr.Length - 1; i++)
        {
            for(int j = i+1; j < charArr.Length; j++)
            {
                if (charArr[i] > charArr[j])
                {
                    char temp = charArr[i];
                    charArr[i] = charArr[j];
                    charArr[j] = temp;
                }
            }
        }

        //converting char array back to a string
        string newStr = "";
        for(int i = 0; i < charArr.Length; i++)
        {
            newStr += charArr[i];
        }

        return newStr;
    }


    // <<<<<-------------------------------1/Aug/24: Homework Questions (4)--------------------->>>>>>
    //1)
    void capitalizeAndAdd2(string str)
    {
        string original = str;
        str = str.ToUpper();
        string newStr = "";
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if(ch != ' ')
            {
                ch = (char)(ch + 2);
                if(ch > 'Z')
                {
                    ch = (char)((ch % 91) + 'A');
                }
            };
            newStr += ch;
        }
        Console.WriteLine($"Input: {original}");
        Console.WriteLine($"Output: {newStr}");
    }

    //2)
    void invertCase(string str)
    {
        char[] charArr = str.ToUpper().ToCharArray();
        string newStr = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (charArr[i] != ' ' && charArr[i] == str[i])
            {
                charArr[i] = (char)(charArr[i] + 32);
            }
            newStr += charArr[i];
        }
        Console.WriteLine($"Input: {str}");
        Console.WriteLine($"Output: {newStr}");
    }
    
    //3)
    void vowelModifier(string str)
    {
        char[] charArr = str.ToLower().ToCharArray();
        string newStr = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (charArr[i] != ' ' && "aeiou".Contains(charArr[i]))
            {
                charArr[i] = (char)(charArr[i] + 1);
            }
            newStr += charArr[i];
        }
        Console.WriteLine($"Input: {str}");
        Console.WriteLine($"Output: {newStr}");
    }   
}

//4) Qus asked to make a complete seperate class
class ArrangeLetters {
    public static void arrange(string str)
    {
        str = str.ToUpper();
        char[] charArr = str.ToCharArray();
        string newStr = "";

        //Selection sort for the win !!!
        for (int i = 0; i < charArr.Length - 1; i++)
        {
            for (int j = i + 1; j < charArr.Length; j++)
            {
                if (charArr[i] > charArr[j])
                {
                    char temp = charArr[i];
                    charArr[i] = charArr[j];
                    charArr[j] = temp;
                }
            }
            newStr += charArr[i];
        }
        newStr += charArr[charArr.Length - 1];

        Console.WriteLine($"Input: {str}");
        Console.WriteLine($"Output: {newStr}");
    }
}
