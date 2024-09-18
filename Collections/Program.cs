class MyClass
{
    public static void Main(string[] args)
    {
        //1)  Lists: add, remove, sort, reverse
        Console.WriteLine("lists");
        List<int> list = new List<int> { 5, 4, 6, 1, 3, 5, 6};

        list.Add(10);
        list.Remove(1);
        list.RemoveAt(1);
        list.Reverse();
        Console.WriteLine("List[0]: "+list[0]);

        list.Sort(); //we can also pass our own comparator function like in C++; useful to sort list of objects
        list.Sort((x, y)=> { 
            if (x > y) return 1; // 1 means swap
            else return -1; // -1 means no swap
        });

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }


        //2)  Hashsets: add, remove
        Console.WriteLine();
        Console.WriteLine("hashsets");
        HashSet<int> set = new HashSet<int> { 5, 4, 3, 2, 1};
        //Console.WriteLine(set[0]); no indexing
        set.Add(0);
        set.Remove(5);
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }

        //3)  Dictionaries
        Console.WriteLine();
        Console.WriteLine("Dictionaries");
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "priyanshu");
        dict.Add(2, "developer");

        Console.WriteLine(dict[1]); //note: this is not index but the key name

        foreach(var item in dict)
        {
            Console.WriteLine(item);
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }

        //4)  Queues: enqueue, dequeue, peek
        Console.WriteLine();
        Console.WriteLine("Queues");
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue();

        Console.WriteLine(queue.Peek());

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        //Console.WriteLine(queue[0]); No Indexing

        //5)  Stacks: push, pop, peek
        Console.WriteLine();
        Console.WriteLine("Stacks");
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
    }
}