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

            Console.WriteLine("Enter First Name To Modify Data : ");
            string UserFirstName = Console.ReadLine();

            if (UserFirstName == personinfo.FirstName)
            {
                Console.WriteLine("Data found");
                Console.WriteLine("Enter What You Wnat to Modify :");
                Console.WriteLine("FirstName, LastName, Address, City, State, ZipCode, Phone Number, Email");

                string userModifyInput = Console.ReadLine();

                if (string.Equals(userModifyInput, "FirstName", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Enter First Name : ");
                    personinfo.FirstName = Console.ReadLine();
                    Console.WriteLine("Updated First Name : " + personinfo.FirstName);
                }
                else if (string.Equals(userModifyInput, "Last Name", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Enter Last Name : ");
                    personinfo.LastName = Console.ReadLine();
                    Console.WriteLine("Updated Last Name : " + personinfo.LastName);
                }
                else if (string.Equals(userModifyInput, "Address", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Enter Address : ");
                    personinfo.Address = Console.ReadLine();
                    Console.WriteLine("Updated Address : " + personinfo.Address);
                }
                else if (string.Equals(userModifyInput, "City", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Enter City Name : ");
                    personinfo.City = Console.ReadLine();
                    Console.WriteLine("Updated City  : " + personinfo.City);
                }
                else if (string.Equals(userModifyInput, "state", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Enter State : ");
                    personinfo.State = Console.ReadLine();
                    Console.WriteLine("Updated State : " + personinfo.State);
                }
                else if (string.Equals(userModifyInput, "ZipCode", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Enter Zip-Code : ");
                    personinfo.ZipCode = int.Parse(Console.ReadLine());
                    Console.WriteLine("Updated Zip-Code : " + personinfo.ZipCode);
                }
                else if (string.Equals(userModifyInput, "phone Number", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Enter Phone Number: ");
                    personinfo.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Updated Phone Number : " + personinfo.PhoneNumber);
                }
                else if (string.Equals(userModifyInput, "Email", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Enter Email - ID: ");
                    personinfo.EmailId = Console.ReadLine();
                    Console.WriteLine("Updated Email- ID : " + personinfo.EmailId);


                }

            }
            else
            {
                //Display Message
                Console.WriteLine("Entered Name : " + UserFirstName + " not Found!");
            }
        }

    }
}
