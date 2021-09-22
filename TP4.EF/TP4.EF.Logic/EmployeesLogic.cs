using System;
using System.Collections.Generic;
using System.Linq;
using TP4.EF.Data;
using TP4.EF.Entities;

namespace TP4.EF.Logic
{
    public class EmployeesLogic : ILogic<Employees>
    {
        NorthwindContext context = new NorthwindContext();

        public int Add(Employees customers)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employees> GetAll()
        {
            var employees = from c in context.Employees select c;
            return employees.ToList();

        }

        public Employees GetByID(int id)
        {
            var employees = from c in context.Employees
                            where c.EmployeeID == id
                            select c;
            return employees.FirstOrDefault();
        }

        public Employees GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public void Modify(Employees paramCustomers)
        {
            throw new NotImplementedException();
        }
    }
}
