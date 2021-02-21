using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("---------------Registration completed successfully---------------");
            Console.WriteLine("Name/Surname: " + customer.Name + " " + customer.Surname);
            Console.WriteLine("Age: " + customer.Age);
            Console.WriteLine("Id: " + customer.Id);
            Console.WriteLine("Explanation: " + customer.Explanation);
            Console.WriteLine("-----------------------------------------------------------------\n");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " has been deleted from the system.");
        }

        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("Customer List:");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " / " + customer.Name + " " + customer.Surname + " / " + customer.Age + " / " + customer.Explanation);

            }
        }
    }
}
