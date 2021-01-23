using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            MusteriManager musteriManager = new MusteriManager();

            customers.Add(musteriManager.AddCustomer(1, "MusteriAdi_1", "MusteriSoyadi_1", "Meslek_1", 3000));
            customers.Add(musteriManager.AddCustomer(2, "MusteriAdi_2", "MusteriSoyadi_2", "Meslek_2", 3500));
            customers.Add(musteriManager.AddCustomer(3, "MusteriAdi_3", "MusteriSoyadi_3", "Meslek_3", 4000));
            customers.Add(musteriManager.AddCustomer(4, "MusteriAdi_4", "MusteriSoyadi_4", "Meslek_4", 4500));
            customers.Add(musteriManager.AddCustomer(5, "MusteriAdi_5", "MusteriSoyadi_5", "Meslek_5", 5000));

            musteriManager.ListCustomers(customers);

            Console.WriteLine("***********************************************************************************");

            musteriManager.DeleteCustomer(customers, 3);

            musteriManager.ListCustomers(customers);
        }
    }    
}
