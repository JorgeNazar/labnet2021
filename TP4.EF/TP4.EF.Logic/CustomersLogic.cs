using System;
using System.Collections.Generic;
using System.Linq;
using TP4.EF.Data;
using TP4.EF.Entities;

namespace TP4.EF.Logic
{
    public class CustomersLogic : ILogic<Customers>
    {
        NorthwindContext context = new NorthwindContext();
        public List<Customers> GetAll()
        {
            var customers = from c in context.Customers select c;
            return customers.ToList();

        }

        public Customers GetByID(string id)
        {
            var customers = from c in context.Customers
                          where c.CustomerID == id
                          select c;
            
            return customers.FirstOrDefault();
            
        }

        public int Add(Customers customers)
        {
            context.Customers.Add(customers);
            return context.SaveChanges();
        }

        public void Delete(string id)
        {
            context.Customers.Remove(GetByID(id));
            context.SaveChanges();
        }

        public void Modify(Customers paramCustomers)
        {
            try
            {
                var customers = context.Customers.Find(paramCustomers.CustomerID);
                
                customers.CompanyName = paramCustomers.CompanyName;
                customers.ContactName  = paramCustomers.ContactName;
                customers.ContactTitle = paramCustomers.ContactTitle;
                customers.Address = paramCustomers.Address;
                customers.City = paramCustomers.City;
                customers.Region = paramCustomers.Region;
                customers.PostalCode = paramCustomers.PostalCode;
                customers.Country = paramCustomers.Country;
                customers.Phone = paramCustomers.Phone;
                customers.Fax = paramCustomers.Fax;

                
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
