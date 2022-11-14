using AddressBook2;
using System;
using System.Net;
using System.Numerics;
using System.Reflection.Emit;

namespace AddBook2;
class Program
{
    static void Main(string[] args)
    {
        AddNewContacts obj = new AddNewContacts();
        Console.WriteLine("Entet the number of people you want to add");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Enter details for " + i + " contact");
            Console.WriteLine("Enter the first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter the state");
            String state = Console.ReadLine();
            Console.WriteLine("Enter the Zipcode");
            string ZipCode = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            string Phone = Console.ReadLine();

            //Adding Details
            obj.AddContact(FirstName, LastName, Email, Address, City, state, ZipCode, Phone);
            Console.WriteLine("Contact Added\n");
        }
        Console.WriteLine("Contact details are:");
        //Displaying details
        obj.Display();
    }
}
