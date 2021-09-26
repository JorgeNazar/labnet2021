using System.Collections.Generic;
using System.Linq;
using TP5.LQ.Data;
using TP5.LQ.Entities;

namespace TP5.LQ.Logic
{
    public class ProductsLogic
    {
        NorthwindContext context = new NorthwindContext();

       
        public List<Products> QueryTwo()
        {
            //Method Sintax 
            var productsMS = context.Products.Where(p => p.UnitsInStock == 0).ToList();
            return productsMS;

            //Query Sintax 
            //var products = from p in context.Products
            //               where p.UnitsInStock == 0
            //               select p;

            //return products.ToList();
        }
      
        public List<Products> QueryThree()
        {
            var products = from p in context.Products
                           where p.UnitsInStock > 0 && p.UnitPrice > 3
                           select p;
        
            return products.ToList();

        }
       
        public List<Products> QueryFive()
        {
            var products = from p in context.Products
                           where p.ProductID == 789
                           select p;

            List<Products> productList = new List<Products>
            {
                products.FirstOrDefault()
            };
            return productList;
        }
        
        public List<Products> QueryNine()
        {
            var productsMS = context.Products.OrderBy(p => p.ProductName);
            
            return productsMS.ToList();

            //Query Sintax
            //var products = from p in context.Products
            //               orderby p.ProductName 
            //               select p;
            //return products.ToList();
        }
       
        public List<Products> QueryTen()
        {
            var products = from p in context.Products
                           orderby p.UnitsInStock descending
                           select p;
            return products.ToList();
        }

        //PUNTO 11 ------------------------------------------------------
        //public List<Products> QueryEleven()
        //{
           
        //}

        //PUNTO 12 ------------------------------------------------------
        public List<Products> QueryTwelve()
        {

            var products = from p in context.Products
                           select p;

            List<Products> productList = new List<Products>
            {
                products.First()
            };
            return products.ToList();
        }

    }
}
