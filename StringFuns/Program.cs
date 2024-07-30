class StringFuns
{
    //This class contains reusable methods that takes strings and params and returns modified strings
    //I'll only make the Main class for testing the functions as its not needed here

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
}