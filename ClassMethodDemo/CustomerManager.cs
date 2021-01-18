using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
       public void CustomerList(Customer[] customer)
        {
            foreach (var customers in customer)
            {
                Console.WriteLine("Account Type: " + customers.AccountType + " / " + "Name: " + customers.Name + " / " + "Surname:  " + customers.Surname);
                Console.WriteLine("************************************************************************");
            }    
        }
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("ID: " + customer.Id + " / " + "Name: " + customer.Name + " / " + "Surname:  " + customer.Surname + " / " + "Account Type: " + customer.AccountType + " New Custommer Added Succesfully");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("ID: " + customer.Id + " / " + "Name: " + customer.Name + " / " + "Surname:  " + customer.Surname + " Account Has Been Deleted! ");
        }


    }
}
