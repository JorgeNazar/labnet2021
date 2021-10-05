using System;
using System.Collections.Generic;
using System.Linq;
using TP4.EF.Data;
using TP4.EF.Entities;

namespace TP4.EF.Logic
{
    public class CustomersLogic : BaseLogic, ILogic<Customers>
    {
        public List<Customers> GetAll()
        {
            try
            {
                var customers = from c in context.Customers select c;
                return customers.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customers GetByID(string id)
        {
            try
            {
                var customers = from c in context.Customers
                              where c.CustomerID == id
                              select c;
            
                return customers.FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Add(Customers customers)
        {
            try
            {
                context.Customers.Add(customers);
                return context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string id)
        {
            try
            {
                context.Customers.Remove(GetByID(id));
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modify(Customers paramCustomers)
        {
            try
            {
                var customers = context.Customers.Find(paramCustomers.CustomerID);
                if (customers == null) return; 
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
