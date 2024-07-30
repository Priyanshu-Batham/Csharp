class Email {
    string[] emails;
    int ptr;
    int length;
    Email(int x)
    {
        length = x;
        emails = new string[length];
        ptr = 0;
    }

    bool addEmail(string email)
    {
        if (ptr == length) return false;
        if (!email.Contains('@') || !email.Contains('.')) return false;
        emails[ptr++] = email;
        return true;
    }

    void printEmails()
    {
        for (int i = 0; i < ptr; i++)
        {
            Console.WriteLine(emails[i]);
        }
    }

    void printComEmails()
    {
        for (int i = 0; i < ptr; i++)
        {
            if(emails[i].EndsWith(".com")) Console.WriteLine(emails[i]);
        }
    }

    public static void Main()
    {
        Email app = new Email(10);

        //rendering CLI 
        while (true)
        {
            Console.WriteLine("1: Enter Email");
            Console.WriteLine("2: View All Emails");
            Console.WriteLine("3: View .com Emails");
            Console.WriteLine("4: Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine() !);

            switch (choice) {
                case 1:
                    
                    Console.WriteLine("Enter your email address: ");
                    string email = Console.ReadLine() !;
                    bool res = app.addEmail(email);
                    if (res == true) Console.WriteLine("Email Added Successfully");
                    else Console.WriteLine("Email Not Added");
                    break;

                case 2:
                    app.printEmails();
                    break;

                case 3:
                    app.printComEmails();
                    break;

                case 4:
                    Console.WriteLine("ThankYou");
                    return;

                default:
                    Console.WriteLine("Enter Valid Input");
                    break;
            }
        }
    }
}
