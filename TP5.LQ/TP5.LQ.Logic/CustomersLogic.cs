using System;
using System.Collections.Generic;
using System.Linq;
using TP5.LQ.Data;
using TP5.LQ.Entities;

namespace TP5.LQ.Logic
{
    public class CustomersLogic
    {
        NorthwindContext context = new NorthwindContext();

        // PUNTO 1 ---------------------------------------------------------------
        public List<Customers> QueryOne()
        {
            var customers = from c in context.Customers select c;
            List<Customers> result = new List<Customers>
            {
                customers.FirstOrDefault()
            };


            return result;
        }
    
        public List<Customers> QueryFour()
        {
            var customersMS = context.Customers.Where(c => c.Region == "WA").ToList();
            return customersMS;

         //QuerySintax 
            //var customers = from c in context.Customers 
            //                where c.Region == "WA"
            //                select c;
            //return customers.ToList();
        
        }
        
        public List<CustomersCustom> QuerySix()
        {



            var customers = from c in context.Customers
                            select c;

            List<CustomersCustom> lstCCustom = new List<CustomersCustom>();

            foreach (var item in customers)
            {
                CustomersCustom cCustom = new CustomersCustom
                {
                    NameLower = item.ContactName.ToLower(),
                    NameUpper = item.ContactName.ToUpper()
                };
                lstCCustom.Add(cCustom);
            }

            return lstCCustom;
        }
   
        public List<CustomersOrders> QuerySeven()
        {
            var customersOrders = from o in context.Orders
                                  join c in context.Customers
                                  on o.CustomerID equals c.CustomerID
                                  where c.Region == "WA" && o.OrderDate > new DateTime(1997, 01, 01)
                                  select new CustomersOrders
                                  { ContactName = c.ContactName, RegionName = c.Region, OrderDate = (DateTime)o.OrderDate };

            return customersOrders.ToList();
        }
       
        public List<Customers> QueryEight()
        {

            List<Customers> result = new List<Customers>();

            var customers = from c in context.Customers
                            where c.Region == "WA"
                            select c;

            List<Customers> customersList = customers.ToList();

           
            result.Add(customersList[0]);
            result.Add(customersList[1]);
            result.Add(customersList[2]);

            //Si se reemplaza la ultima linea por result.Add(customersList[3]); se generaria un error
            //ya que solo existen tres clientes con la condicion de perteneces a la region WA

            return result;
            
        }
    }
}
