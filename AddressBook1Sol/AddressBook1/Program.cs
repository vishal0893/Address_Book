using AddressBook1;
using System;
namespace AddBook1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book program.\n");
        AddContacts obj=new AddContacts();
        obj.InsertDetails();
        obj.ViewDetails();
    }
}
