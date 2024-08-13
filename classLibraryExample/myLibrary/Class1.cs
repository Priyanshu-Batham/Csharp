namespace myLibrary
{

    public class MyStringFuns {
        //1)
        public string centerHeading(string str)
        {
            str = str.PadLeft(str.Length + 20, '-');
            str = str.PadRight(str.Length + 20, '-');
            str = str.PadLeft(str.Length + 3, '<');
            str = str.PadRight(str.Length + 3, '>');
            return str;
        }

        //2)
        public bool isValidEmail(string str)
        {
            if (!str.Contains('@') || !str.Contains('.')) return false;
            return true;
        }

        //3)
        public string reverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //4)
        public bool isPallindrome(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            return str.Equals(new string(charArray));
        }

        //5)
        public int countVowels(string str)
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
        public string removeDuplicates(string str)
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
        public void findAllSubstrings(string str)
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
        public string findLongestWord(string sentence)
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
        public int countWords(string str)
        {
            //we can pass a whole array of chars to determine the splitter
            //remove empty entries is done to get rid of duplicate empty spaces
            string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        //10)
        public bool areAnagrams(string str1, string str2)
        {
            char[] charArray1 = str1.ToLower().ToCharArray();
            char[] charArray2 = str2.ToLower().ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            //Equals function wasn't working here :(
            return charArray1.SequenceEqual(charArray2);
        }

        //--------------------------NUMBER PROGS---------------------------->>>>
        //1)
        public int complement(int n)
        {
            return -(n + 1);
        }

        //2)
        public int add3(int n)
        {
            return n + 3;
        }
        //3)
        public int add4(int n)
        {
            return n + 4;
        }
        //4)
        public int add5(int n)
        {
            return n + 5;
        }
        //5)
        public int add6(int n)
        {
            return n + 6;
        }
        //6)
        public int add7(int n)
        {
            return n + 7;
        }
        //7)
        public int add8(int n)
        {
            return n + 8;
        }
        //8)
        public int add9(int n)
        {
            return n + 9;
        }
        //9)
        public int add0(int n)
        {
            return n + 0;
        }
        //10)
        public int add1(int n)
        {
            return n + 1;
        }
    }

}
