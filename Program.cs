// See https://aka.ms/new-console-template for more information
using Phone_Book_Application;
Console.Write("Enter your username: ");
string name = Console.ReadLine();
var phonebooklist1 = new PhoneBookList<PhoneBookModel>();

while (true)
{
    System.Console.WriteLine("PHONE BOOK APPLICATION");
    Console.WriteLine("-----------------------------");
    System.Console.WriteLine($"Welcome '{name}', to the Phone book application");
    System.Console.WriteLine("Select any one of the options");
    System.Console.WriteLine("a. Make a new Entry");
    System.Console.WriteLine("b. View all Entries");
    System.Console.WriteLine("c. Update an Entry");
    System.Console.WriteLine("d. Search for an Entry");
    System.Console.WriteLine("e. Delete an Entry");
    System.Console.WriteLine("q. Exit");

    var answer = Console.ReadLine();
    int count=0;
    
    if (answer == "a")
    {
        Console.Write("Enter name: ");
        string val = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        string val2 = Console.ReadLine();

        Console.Write("Enter Address: ");
        string val3 = Console.ReadLine();

        var instance = new PhoneBookModel(val,val2,val3);
        phonebooklist1.AddAnEntry(instance);
        
        System.Console.WriteLine("New Entry Added Successfully");
        
        
        foreach (var entry in phonebooklist1.ViewAllEntry())
        {
            count++;
            Console.Write(Convert.ToString(count));
            System.Console.WriteLine(entry);
        }
        System.Console.WriteLine("Press Enter to Continue");
        Console.ReadLine();
    }

    // foreach (var entry in phonebooklist1.ViewAllEntry())
    // {
    //     System.Console.WriteLine(entry.Value);
    // }
    
    else if (answer == "b")
    {
        
        foreach (var entry in phonebooklist1.ViewAllEntry())
        {
            count++;
            Console.Write(Convert.ToString(count));
            System.Console.WriteLine(entry);
        }
        Console.ReadLine();
    }

    else if (answer == "c")
    {
        foreach (var entry in phonebooklist1.ViewAllEntry())
        {
            count++;
            Console.Write(Convert.ToString(count));
            System.Console.WriteLine(entry);
        }
        Console.Write("Enter the number of the Entry you want to Update: ");
        int num = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("What would you like to update? ");
        System.Console.WriteLine("1. Name");
        System.Console.WriteLine("2. Phone Number");
        System.Console.WriteLine("3. Address");
        var ans = Convert.ToString(Console.ReadLine());
        if (ans == "1")
        {
            Console.Write("Enter new Name: ");
            var val1 = Console.ReadLine();
            phonebooklist1.UpdateName(num,val1);
            System.Console.WriteLine("Name Successfully updated");
        }
        else if (ans == "2")
        {
            Console.Write("Enter New Number: ");
            var val2 = Console.ReadLine();
            phonebooklist1.UpdatePhonenumber(num,val2);
            System.Console.WriteLine("Phone Number sucessfully updated");
        }
        else if (ans =="3")
        {
            Console.Write("Enter New Address: ");
            var val3 = Console.ReadLine();
            phonebooklist1.UpdateAddress(num, val3);
            System.Console.WriteLine("Address Successfully updated");
            // System.Console.WriteLine($"Address {entry.Value.Address}, has been updated to {val3}");
        }
        Console.ReadLine();
    }

    else if (answer == "d")
    {
        System.Console.WriteLine("What would you like to Search By? ");
        System.Console.WriteLine("1. Name");
        System.Console.WriteLine("2. Phone Number");
        System.Console.WriteLine("3. Address");
        var ans = Convert.ToString(Console.ReadLine());
        if (ans == "1")
        {
            Console.Write("Enter Search Name: ");
            var result = Console.ReadLine();
            phonebooklist1.SearchAnEntry(result);
            System.Console.WriteLine("Search Success!");
            Console.ReadLine();
        }

        else if(ans == "2")
        {
            Console.Write("Enter Search Phone Number: ");
            var result = Console.ReadLine();
            phonebooklist1.SearchNumber(result);
            System.Console.WriteLine("Search Success!");
            System.Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }

        else if (ans == "3")
        {
            Console.Write("Enter Search Name: ");
            var result = Console.ReadLine();
            phonebooklist1.SearchAddress(result);
            System.Console.WriteLine("Search Success!");
            System.Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
    }

    else if (answer == "e")
    {
        foreach (var entry in phonebooklist1.ViewAllEntry())
        {
            count++;
            Console.Write(Convert.ToString(count));
            System.Console.WriteLine(entry);
        }
        Console.Write("Enter the # you want to Delete: ");
        var result = Convert.ToInt32(Console.ReadLine());
        phonebooklist1.DeleteAnEntry(result);
        System.Console.WriteLine("Entry Deleted Sucessfully");
        Console.ReadLine();
    }

    else if (answer == "q")
    {
        break;
    }  
}