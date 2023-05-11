using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookOOPs
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string cityName;
        private string stateName;
        private int zipCode;
        private int contactNumber;
        private string emailID;

        public Contact(string firstName, string lastName,string address,string city,string state,int zip,int contact, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.cityName = city;
            this.stateName = state;
            this.zipCode = zip;
            this.contactNumber = contact;
            this.emailID = email;
        }

        public void AddDetails()
        {
            Console.WriteLine("Hi! {0} {1}, your details have been updated successfully ",this.firstName,this.lastName);
        }
        //public void viewDetails()
        //{
        //    Console.WriteLine("first name:" + this.firstName);
        //    Console.WriteLine("last name:"+this.lastName);
        //    Console.WriteLine("address:"+this.address);
        //    Console.WriteLine("city:"+this.cityName);
        //    Console.WriteLine("state:"+this.stateName);
        //    Console.WriteLine("zipcode:"+this.zipCode);
        //    Console.WriteLine("contact number:"+this.contactNumber);
        //    Console.WriteLine("email ID:"+this.emailID);
        //}
    }
}
