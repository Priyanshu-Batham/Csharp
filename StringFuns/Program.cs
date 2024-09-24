using System.Security.Cryptography.X509Certificates;

class StringFuns
{
    //This class contains reusable methods that takes strings and params and returns modified strings
    //I'll only make the Main class for testing the functions as its not needed here
    public static void Main()
    {
        StringFuns app = new StringFuns();
        //app.vowelModifier("Hello How are you");
        ArrangeLetters.arrange("BaSica");
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

    //11)
    string reverseWords(string str)
    {
        string[] arr = str.Split(' ');
        string newStr = "";

        for (int i = 0; i < arr.Length; i++)
        {
            newStr += arr[arr.Length - 1 - i];
            newStr += " ";
        }

        return newStr;
    }

    //12) (Heist Codes)
    public void findSmallLarge()
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine()!;
        str = str + " ";
        int i, n = str.Length, count = 0, max = 0, min = 0;

        for (i = 0; i < n; i++)
        {
            if (str[i] != ' ')
                count++;
            if (str[i] == ' ')
            {
                if (count > max)
                {
                    max = count;
                    count = 0;
                }
            }
        }
        count = 0;
        Console.WriteLine("Biggest word has " + max + " Letters");
        min = max;
        for (i = 0; i < n; i++)
        {
            if (str[i] != ' ')
                count++;
            if (str[i] == ' ')
            {
                if (count < min)
                {
                    min = count;
                    count = 0;
                }
            }
        }
        Console.WriteLine("Smallest word has " + min + " Letters");
    }

    //13)
    public void combineStrings()
    {
        Console.WriteLine("Enter string 1");
        string str1 = Console.ReadLine()!;
        Console.WriteLine("Enter string 2");
        string str2 = Console.ReadLine()!;
        string str3 = "";
        str2 = " " + str2;
        char ch = ' ';
        int i, n1 = str1.Length, n2 = str2.Length, n3 = n1 + n2;
        for (i = 0; i < n3; i++)
        {
            if (i < n1)
            {
                ch = str1[i];
                str3 += ch;
            }
            else
            {
                ch = str2[i % n2];
                str3 += ch;
            }
        }
        Console.WriteLine("Combind String: " + str3);
    }

    //14)
    public void checkSub()
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine()!;
        Console.WriteLine("Enter substring you want to check");
        string substr = Console.ReadLine()!;

        int i, n1 = str.Length, n2 = substr.Length, count = 0, m = 0;
        char ch = substr[0];
        //bool flag = true;

        for (i = 0; i < n1; i++)
        {
            if (str[i] == ch)
            {
                m = i;
                break;
            }
        }
        for (i = m; i <= n1; i++)
        {
            if (str[i] == substr[count])
            {
                count++;
            }
            if (count == n2)
            {
                break;
            }
        }
        if (count == n2)
            Console.WriteLine("String contains inputted Substring");
        else
            Console.WriteLine("String does NOT contain the substring");
    }

    //15)
    public void extractSub()
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine()!;
        int n = str.Length, i, m1 = 0, m2 = 0;
        Console.WriteLine("Enter starting index");
        m1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter ending index");
        m2 = Convert.ToInt32(Console.ReadLine());

        if (m1 < n && m2 < n && m1 < m2)
        {
            for (i = m1; i < m2; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Please give proper inputs");
        }

    }

    //16)
    public void countFreq()
    {
        int[] ch_freq = new int[128];
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine()!;
        int n = str.Length;

        for (int i = 0; i < n; i++)
        {
            if (str[i] != ' ')
            {
                int ascii = str[i];
                ch_freq[ascii]++;
            }
        }

        int max = 0;
        char maxChar = ' ';
        for (int i = 0; i < 128; i++)
        {
            if (ch_freq[i] > max)
            {
                max = ch_freq[i];
                maxChar = (char)i;
            }
        }

        Console.WriteLine("Character: " + maxChar);
        Console.WriteLine("Frequency: " + max);
    }

    //17)
    public void countEverything()
    {
        Console.WriteLine("Enter a String");
        string str = Console.ReadLine() ?? string.Empty; // Handle null input
        int alphabet = 0, number = 0, sp_char = 0;

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            int ascii = ch;

            if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122))
            {
                alphabet++;
            }
            else if (ascii >= 48 && ascii <= 57)
            {
                number++;
            }
            else
            {
                sp_char++;
            }
        }

        Console.WriteLine("Number of Alphabets: " + alphabet);
        Console.WriteLine("Number of Numbers: " + number);
        Console.WriteLine("Number of Special Characters: " + sp_char);
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
class ArrangeLetters
{
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

        Console.WriteLine($"Word in Capital: {str}");
        Console.WriteLine($"Word after sorting: {newStr}");
    }
}
    
