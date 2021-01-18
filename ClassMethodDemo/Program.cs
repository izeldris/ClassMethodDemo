using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 141;
            customer1.Name = "John";
            customer1.Surname="Price";
            customer1.AccountType = "Individual";
            customer1.Balance=6541.8;

            Customer customer2 = new Customer();
            customer2.Id = 142;
            customer2.Name = "John";
            customer2.Surname = "MacTavish";
            customer2.AccountType = "Individual";
            customer2.Balance = 4780;

            Customer customer3 = new Customer();
            customer3.Id = 143;
            customer3.Name = "Simon";
            customer3.Surname = "Riley";
            customer3.AccountType = "Individual";
            customer3.Balance = 5210;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("Listing Sequence is Beginning...");
            customerManager.CustomerList(customers);
            Console.WriteLine("  Listing Completed Successfully.");
            Console.WriteLine("************************************************************");

            Console.WriteLine("Adding Customers...");
            customerManager.AddCustomer(customer1);
            Console.WriteLine("************************************************************");
            customerManager.AddCustomer(customer2);
            Console.WriteLine("************************************************************");
            customerManager.AddCustomer(customer3);
            Console.WriteLine("************************************************************");



            Console.WriteLine("Deleting Customer...");
            customerManager.DeleteCustomer(customer1);
            Console.WriteLine("************************************************************");

        }   
    }
}
