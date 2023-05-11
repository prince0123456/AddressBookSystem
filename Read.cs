using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookOOPs
{
    public class Read
    {
        public void readData()
        {
            Console.WriteLine("\nPlease enter you data.");
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your city name:");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your state name:");
            string state = Console.ReadLine();
            Console.WriteLine("Enter city zipcode:");
            int zipcode=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your contact number:");
            int contact= (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email ID:");
            string email = Console.ReadLine();

            Contact entry = new Contact(firstName,lastName,address,city,state,zipcode,contact,email);
            entry.AddDetails();
        }

       
    }
}
