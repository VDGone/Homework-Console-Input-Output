using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintCompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter company name: ");
            string companyName = Console.ReadLine();

            Console.WriteLine("Enter company adress");
            string companyAdress = Console.ReadLine();

            Console.WriteLine("Enter phone number(359xxxxxxxxx no spaces) : ");
            ulong phoneNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Enter fax number: ");
            ulong faxNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine("Enter web site: ");
            string webSite = Console.ReadLine();

            Console.WriteLine("Enter manager first name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter manager last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Enter manager age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter manager phone number (359xxxxxxxxx no spaces): ");
            ulong managerPhoneNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine("\nCompany name: {0}\nCompany address: {1}\nPhone number: +{2}\nFax number: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel: +{8})",
            companyName, companyAdress, phoneNumber, faxNumber, webSite, fName, lName, age, managerPhoneNumber);

        }
    }
}
