using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    class AddNewContacts
    {
        //creating list of type person class
        List<person> p = new List<person>();
        public void AddContact(string firstname, string lastname, string email, string address, string city, string state, string zipcode, string phone)
        {
            //adding value in list by creating separate objects For each data
            p.Add(new person(firstname, lastname, email, address, city, state, zipcode, phone));
        }
        public void Display()
        {
            foreach (var person in p)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.Email);
                Console.WriteLine(person.Address);
                Console.WriteLine(person.City);
                Console.WriteLine(person.State);
                Console.WriteLine(person.ZipCode);
                Console.WriteLine(person.Phone);
            }
        }
    }
}

        
