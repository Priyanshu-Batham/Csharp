class Practical {
    //Qus1
    bool anagramChecker(string str, string word)
    {
        for (int i = 0; i < str.Length - word.Length; i++)
        {
            string sortedStr = new String(str.Substring(i, word.Length).OrderBy(str => str).ToArray());
            string sortedWord = new string(word.OrderBy(str => str).ToArray());

            if (sortedStr == sortedWord) return true;
        }
        return false;
    }

    //Qus2
    //Method 1 (using simple array)
    int noOfPairs(string str)
    {
        int count = 0;
        int[] countArr = new int[26];

        foreach(char ch in str) countArr[ch - 'a']++;
        foreach (int cell in countArr) count += cell / 2;

        return count;
    }

    //Method 2 (using Dictionary from System.generic.Collections
    int noOfPairsUsingDict(string str)
    {
        int count = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char ch in str)
        {
            if (dict.ContainsKey(ch)) dict[ch]++;
            else dict.Add(ch, 1);            
        }
        foreach(var item in dict) count += item.Value / 2;
        
        return count;
    }

    public static void Main(string[] args)
    {
        Practical qus = new Practical();
        //Console.WriteLine(qus.anagramChecker("grab", "bag"));
        //Console.WriteLine(qus.noOfPairs("aabcbbccc"));
        //Console.WriteLine(qus.noOfPairsUsingDict("aabcbbccc"));
    }
}
