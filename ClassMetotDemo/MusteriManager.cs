using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public  Customer AddCustomer(int Id, string name, string surname, string job, double monthlyIncome)
        {
            Customer customer = new Customer();
            customer.Id = Id;
            customer.Name = name;
            customer.Surname = surname;
            customer.Job = job;
            customer.MonthlyIncome = monthlyIncome;

            return customer;
        }

        public  void ListCustomers(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Adı " + customer.Name
                    + ", Soyadı : " + customer.Surname
                    + ", Mesleği : " + customer.Job
                    + ", Aylık Geliri : " + customer.MonthlyIncome);
            }
        }

        public  void DeleteCustomer(List<Customer> customers, int id)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    customers.Remove(customers[i]);
                }
            }
        }
    }
}
