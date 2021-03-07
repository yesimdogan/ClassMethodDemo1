using System;
using System.Collections.Generic;
namespace ClassMethodDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Yeşim";
            customer1.Surname = "D.";
            customer1.PhoneNumber = 9000000;
            customer1.EMail = "yesimd@gmail.com";
            customer1.Adress = "Kocaeli";
            customer1.Limit = 6000;

            Customer customer2 = new Customer();
            customer2.Name = "Yeliz";
            customer2.Surname = "K.";
            customer2.PhoneNumber = 9100000;
            customer2.EMail = "yelizk@gmail.com";
            customer2.Adress = "İstanbul";
            customer2.Limit = 7000;

            Customer customer3 = new Customer();
            customer3.Name = "Berkin";
            customer3.Surname = "A.";
            customer3.PhoneNumber = 9200000;
            customer3.EMail = "berkina@gmail.com";
            customer3.Adress = "İzmir";
            customer3.Limit = 4000;

            Customer customer4 = new Customer();
            customer4.Name = "Vera";
            customer4.Surname = "E.";
            customer4.PhoneNumber = 9300000;
            customer4.EMail = "verae@gmail.com";
            customer4.Adress = "İzmir";
            customer4.Limit = 4500;


            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.PhoneNumber);
                Console.WriteLine(customer.EMail);
                Console.WriteLine(customer.Adress);
                Console.WriteLine(customer.Limit + "\n");
            }

            Console.WriteLine("***************");

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customers);

            Console.ReadKey();
        }
    }
}
