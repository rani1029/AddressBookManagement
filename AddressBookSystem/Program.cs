using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address Book Management system");

            Person personinfo = new Person();

            Console.WriteLine(" add contacts");

            Console.WriteLine(" enter FirstName");
            personinfo.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            personinfo.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address : ");
            personinfo.Address = Console.ReadLine();

            Console.WriteLine("Enter City Name : ");
            personinfo.City = Console.ReadLine();

            Console.WriteLine("Enter State Name : ");
            personinfo.State = Console.ReadLine();

            Console.WriteLine("Enter Zip-Code : ");
            personinfo.ZipCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Number : ");
            personinfo.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email-ID : ");
            personinfo.EmailId = Console.ReadLine();


        }
    }
}
