using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

class PhoneBook
{
    string?[] name;
    string?[] number;
    int count;

    //Constructor
    PhoneBook(int size = 100)
    {
        name = new string[size];
        number = new string[size];
        count = 0;
    }

    //Create
    void createContact(string name, string number)
    {
        for (int i = 0; i < this.name.Length; i++)
        {
            if (this.name[i] == null)
            {
                this.name[i] = name;
                this.number[i] = number;
                this.count++;
                break;
            }
        }
        Console.WriteLine("Contact created successfully");
    }
    
    //Read
    void readContacts()
    {
        Console.WriteLine("<<<<--------------------PhoneBook Contacts-------------------->>>>");
        for(int i = 0; i < this.name.Length; i++)
        {
            if (this.name[i] != null)
            {
                Console.WriteLine($"index:{i+1}, name:{this.name[i]}, number:{this.number[i]}");
            }
        }
        Console.WriteLine("<<<<---------------------------------------------------------->>>>");
    }
    
    //Update
    //!!! Provide at least one search and one update param
    void updateContact(string? searchName = null, string? searchNumber = null, string? updatedName = null, string? updatedNumber = null)
    {
        int index = -1;
        //finding index by name
        if (searchName != null)
        {
            for(int i = 0; i<this.name.Length; i++)
            {
                if (this.name[i] == searchName)
                {
                    index = i; break;
                }
            }
        }
        //finding index by number
        else if(searchNumber != null)
        {
            for (int i = 0; i < this.number.Length; i++)
            {
                if (this.number[i] == searchNumber)
                {
                    index = i; break;
                }
            }
        }
        //if index is still -1 means no matching contact
        if(index == -1)
        {
            Console.WriteLine("Contact not found");
            return;
        }
        //if index is found then update the name/number
        if(updatedName != null) this.name[index] = updatedName;
        if(updatedNumber != null) this.number[index] = updatedNumber;
        Console.WriteLine("Contact Updated Successfully");
    }
    
    //Delete
    void deleteContact(string? searchName = null, string? searchNumber = null)
    {
        int index = -1;
        //finding index by name
        if (searchName != null)
        {
            for (int i = 0; i < this.name.Length; i++)
            {
                if (this.name[i] == searchName)
                {
                    index = i; break;
                }
            }
        }
        //finding index by number
        else if (searchNumber != null)
        {
            for (int i = 0; i < this.number.Length; i++)
            {
                if (this.number[i] == searchNumber)
                {
                    index = i; break;
                }
            }
        }
        //if index is still -1 means no matching contact
        if (index == -1)
        {
            Console.WriteLine("Contact not found");
            return;
        }
        //if index is found then delete contact
        this.name[index] = null;
        this.number[index] = null;
        Console.WriteLine("Contact Deleted Successfully");
    }

    public static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook(100);

        //Rendering CLI for User
        while (true)
        {
            Console.WriteLine("1: Create Contact");
            Console.WriteLine("2: Update Contact");
            Console.WriteLine("3: Delete Contact");
            Console.WriteLine("4: Read Contacts");
            Console.WriteLine("5: Exit");
            Console.Write("Enter: ");
            int crudChoice = int.Parse(Console.ReadLine()!);

            //create
            if (crudChoice == 1)
            {
                //taking user input
                Console.Write("Enter Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Enter Number: ");
                string number = Console.ReadLine()!;

                //if user is crazy
                if (name == "" || number == "" || number.Length < 10)
                {
                    Console.WriteLine("Enter Information Properly");
                }
                else
                {
                    phoneBook.createContact(name, number);
                }
            }
            //update
            else if (crudChoice == 2)
            {
                //taking user input
                Console.Write("Search user by name(1) or number(2)?");
                int searchNameOrnumChoice = int.Parse(Console.ReadLine()!);

                //search by name
                if (searchNameOrnumChoice == 1)
                {
                    Console.Write("Enter Name: ");
                    string searchName = Console.ReadLine()!;

                    Console.Write("Update name(1) or number(2)?");
                    int updateNameOrnumChoice = int.Parse(Console.ReadLine()!);

                    //update name
                    if (updateNameOrnumChoice == 1)
                    {
                        Console.Write("Enter Updated Name: ");
                        string updatedName = Console.ReadLine()!;
                        phoneBook.updateContact(searchName: searchName, updatedName: updatedName);
                    }
                    //update number
                    else if (updateNameOrnumChoice == 2)
                    {
                        Console.Write("Enter Updated Number: ");
                        string updatedNumber = Console.ReadLine()!;
                        phoneBook.updateContact(searchName: searchName, updatedNumber: updatedNumber);
                    }

                }
                //search by number
                else if (searchNameOrnumChoice == 2)
                {
                    Console.Write("Enter Number: ");
                    string searchNumber = Console.ReadLine()!;

                    Console.Write("Update name(1) or number(2)?");
                    int updateNameOrnumChoice = int.Parse(Console.ReadLine()!);

                    //update name
                    if (updateNameOrnumChoice == 1)
                    {
                        Console.Write("Enter Updated Name: ");
                        string updatedName = Console.ReadLine()!;
                        phoneBook.updateContact(searchNumber: searchNumber, updatedName: updatedName);
                    }
                    //update number
                    else if (updateNameOrnumChoice == 2)
                    {
                        Console.Write("Enter Updated Number: ");
                        string updatedNumber = Console.ReadLine()!;
                        phoneBook.updateContact(searchNumber: searchNumber, updatedNumber: updatedNumber);
                    }
                }
            }
            //delete
            else if (crudChoice == 3)
            {
                //taking user input
                Console.Write("Search user by name(1) or number(2)?");
                int searchNameOrnumChoice = int.Parse(Console.ReadLine()!);

                //search by name
                if (searchNameOrnumChoice == 1)
                {
                    Console.Write("Enter Name: ");
                    string searchName = Console.ReadLine()!;
                    phoneBook.deleteContact(searchName: searchName);
                }
                //search by number
                else if (searchNameOrnumChoice == 2)
                {
                    Console.Write("Enter Number: ");
                    string searchNumber = Console.ReadLine()!;
                    phoneBook.deleteContact(searchNumber: searchNumber);
                }
            }
            //read
            else if (crudChoice == 4)
            {
                phoneBook.readContacts();
            }
            //exit
            else if (crudChoice == 5)
            {
                Console.WriteLine("ThankYou");
                break;
            }
            //Invalid input
            else
            {
                Console.WriteLine("Enter valid inputs");
            }
        }
    }
}