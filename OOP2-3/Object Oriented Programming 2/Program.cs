using System;

namespace ObjectOriantedP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Alihan Demirdaş
            Person customer1 = new Person();
            customer1.CustomerNumber = "12345";
            customer1.Name = "Alihan";
            customer1.Surname = "Demirdaş";
            customer1.IdNumber = "123456789";

            //Limrenc Company
            Company customer2 = new Company();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Limrenc";
            customer2.TaxNumber = "9876543210";


            Customer customer3 = new Person();
            Customer customer4 = new Company();

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(customer1);
            //customerManager.Add(customer2);
            //we can write like this
            


        }
    }
}
