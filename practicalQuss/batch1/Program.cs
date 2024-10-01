namespace AlmostPallindrome
{
    internal class Program
    {
        public string str;

        enum Days
        {
            Monday,
            Tuesday
        }

        Program(string str)
        {
            this.str = str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine()!;
            Program obj = new Program(str);

            obj.checkIsAlmostPallindrome();
            //obj.AlphaPos();
            //obj.enumType();
        }

        bool checkIsAlmostPallindrome()
        {
            int len = str.Length;
            int start = 0;
            int end = len - 1;
            int count = 0;
            int firstPos = 0, lastPos = len - 1;
            bool initialPosTakingDone = false;

            while (start < end)
            {
                if (str[start] != str[end])
                {
                    if(initialPosTakingDone == false)
                    {
                        initialPosTakingDone = true;
                        firstPos = start;
                        lastPos = end;
                    }
                    count++;
                }

                start++;
                end--;
            }
            if (count > 1)
            {
                Console.WriteLine("string cannot be changed into almost pallindrome");
                return false;
            }
            else if(count == 0)
            {
                Console.WriteLine("String is already a pallindrome string");
                return false;
            }
            else if(count == 1)
            {
                Console.WriteLine($"string can be made almost pallindrome by changing {str[lastPos]} to {str[firstPos]}");
                return true;
            }
            return false;
        }

        string AlphaPos()
        {
            string myStr = str.ToLower();
            string newStr = "";
            foreach (char item in myStr)
            {
                //if (item == ' ') continue;
                int pos = item - 'a' + 1;
                if(pos < 1 || pos > 26)
                {
                    Console.WriteLine("Invalid input");
                    return str;
                }
                //Console.WriteLine(item - 'a');                
                newStr += pos.ToString();
            }
            Console.WriteLine($"original string: {str}");
            Console.WriteLine($"after removing unwanted spaces: {myStr}");
            Console.WriteLine($"string converted to alphabet posiitons: {newStr}");
            return newStr;
        }

        void enumType()
        {
            Console.WriteLine(Days.Tuesday.GetType());
        }
    }
}