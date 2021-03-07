using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo1
{
    class CustomerManager
    {

        List<Customer> customersList = new List<Customer>();

        public void Add(Customer customer)
        {
            customersList.Add(customer);
            Console.WriteLine(customer.Name + " " + customer.Surname + " --> Customer added!");
        }

        public void Delete(Customer customer)
        {
            customersList.Remove(customer);
            Console.WriteLine(customer.Name + " " + customer.Surname + "--> Customer deleted!");
        }

        
        public void List(Customer[] customer)
        {
            Console.WriteLine("***************");

            foreach (var x in customersList)
            { 
                Console.WriteLine("Customer's Name : " + x.Name);
                Console.WriteLine("Customer's Surname : " + x.Surname);
                Console.WriteLine("Customer's Phone Number : " + x.PhoneNumber);
                Console.WriteLine("Customer's Adress : " + x.Adress);
                Console.WriteLine("Customer's E-Mail : " + x.EMail);
                Console.WriteLine("Customer's Limit : "  + x.Limit + "\n");

            }
        }
    }

}




