using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressBookOOPs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Able to create a contact list ");
            Console.WriteLine("Enter first name = ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter address= ");
            String address = Console.ReadLine();
            Console.WriteLine("Enter city= ");
            String city = Console.ReadLine();
            Console.WriteLine("Enter state= ");
            String state = Console.ReadLine();
            Console.WriteLine("Enter zip= ");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter phoneNumber= ");
            String phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email= ");
            String email = Console.ReadLine();
            AddressBook builder = new AddressBook();
            builder.AddContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            builder.DisplayContact();
            builder.EditExistingContact();
            builder.DisplayContact();
            builder.DeleteExistingContact();
            builder.DisplayContact();
        }
    }
}