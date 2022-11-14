using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook1
{
    class AddContacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        
        public void InsertDetails()
        {
            Console.WriteLine("Enter the first name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            Email = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            City = Console.ReadLine();
            Console.WriteLine("Enter the state");
            State = Console.ReadLine();
            Console.WriteLine("Enter the Zipcode");
            ZipCode = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            Phone = Console.ReadLine();
            Console.WriteLine("---------DETAILS HAVE BEEN INSERTED----------");
        }
        public void ViewDetails()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Email);
            Console.WriteLine(Address);
            Console.WriteLine(City);
            Console.WriteLine(State);
            Console.WriteLine(ZipCode);
            Console.WriteLine(Phone);
        }
    }
}
