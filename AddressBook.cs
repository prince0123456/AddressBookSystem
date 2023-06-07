﻿using Microsoft.Azure.KeyVault.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookOOPs
{
    class AddressBook
    {
        public List<Contact> ContactsList;
        public AddressBook()
        {
            this.ContactsList = new List<Contact>();
        }
        public void AddContacts(String firstName, String lastName, String address, String city, String state, String zip, String phone, String email)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phone, email);
            this.ContactsList.Add(contact);
        }
        public void DisplayContact()
        {
            foreach (Contact contact in this.ContactsList)
            {
                Console.WriteLine("First Name = " + contact.FirstName);
                Console.WriteLine("Last Name = " + contact.LastName);
                Console.WriteLine("Address = " + contact.Address);
                Console.WriteLine("City  = " + contact.City);
                Console.WriteLine("State = " + contact.State);
                Console.WriteLine("Zip code  = " + contact.Zip);
                Console.WriteLine("Phone number  = " + contact.PhoneNum);
                Console.WriteLine("Email ID  = " + contact.Email);
            }
        }
    }
}
