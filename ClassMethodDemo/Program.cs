using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Berfin";
            customer1.Surname = "Acikgoz";
            customer1.Age = 21;
            customer1.Id = 12345;
            customer1.Explanation = "credit";

            Customer customer2 = new Customer();
            customer2.Name = "Tuba";
            customer2.Surname = "Tasdemir";
            customer2.Age = 30;
            customer2.Id = 78932;
            customer2.Explanation = "donation";

            Customer customer3 = new Customer();
            customer3.Name = "Harun";
            customer3.Surname = "Ust";
            customer3.Age = 20;
            customer3.Id = 78932;
            customer3.Explanation = "green card";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);

            //customerManager.DeleteCustomer(customer2);
            customerManager.ListCustomer(customers);
        }
    }
}
