using System.Security.Principal;

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
        public bool isArmStrong(int n)
        {
            int sum = 0;
            int noOfDigits = countDigits(n);
            foreach (int num in numberToArray(n))
            {
                sum += power(num, noOfDigits);
            }
            return sum == n;
        }
        //3)
        public int power(int n, int pow)
        {
            if (pow == 0) return 1;
            int newNum = 1;
            while(pow-- > 0)
            {
                newNum *= n;
            }
            return newNum;
        }
        //4)
        public int[] numberToArray(int n)
        {
            int count = countDigits(n);
            int[] arr = new int[count];

            for(int i = 0; i<count; i++)
            {
                int dig = n % 10;
                n /= 10;
                arr[count - 1 - i] = dig;
            }
            return arr;
        }
        //5)
        public int countDigits(int n)
        {
            int count = 0;
            while(n > 0)
            {
                count++;
                n /= 10;
            }
            return count;
        }
        //6)
        public bool isPallindromeNumber(int n)
        {
            return (n == reverseNumber(n));
        }
        //7)
        public int reverseNumber(int n)
        {
            int num = n, newNum = 0;
            while(num > 0){
                int dig = num % 10;
                newNum *= 10;
                newNum += dig;
                num /= 10;
            }
            return newNum;
        }
        //8)
        public int factorial(int n)
        {
            if (n < 2) return n;

            return factorial(n - 1) + factorial(n - 2);
        }
        //9)
        public bool isEven(int n)
        {
            return (n & 1) == 0;
        }
        //10)
        public bool isPrime(int n)
        {
            if (n < 2) return true;
            for(int i = 2; i*i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }

}