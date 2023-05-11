using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressBookOOPs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("\nPlease choose one of the options:");
            Console.WriteLine("1)Add Contact");
            Console.WriteLine("4)Exit");
            //Console.WriteLine("\nEnter the option:");
            //int key = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("\nEnter the option:");
                int key = Convert.ToInt32(Console.ReadLine());
                Read read = new Read();
                //Contact contact = new Contact();
                if (key==1)
                {
                    read.readData();
                }
                else if(key==4)
                {
                    Console.WriteLine("\nThank You");
                    break;
                }
            }
        }
    }
}