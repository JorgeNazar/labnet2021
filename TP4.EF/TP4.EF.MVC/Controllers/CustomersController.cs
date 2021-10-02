using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TP4.EF.Entities;
using TP4.EF.Logic;
using TP4.EF.MVC.Models;

namespace TP4.EF.MVC.Controllers
{
    public class CustomersController : Controller
    {
        CustomersLogic logic = new CustomersLogic();
        // GET: Customers
        public ActionResult Index()
        {
            List<Customers> customers = logic.GetAll();
            List<CustomersView> customersView = customers.Select(c => new CustomersView
            {
                Id = c.CustomerID.Trim(),
                ContactName = c.ContactName,
                Phone = c.Phone
            }).ToList();
            return View(customersView);
        }

        public ActionResult Insert()
        {
            return View("Insert");
        }
        public ActionResult InsertAction(string Id, string ContactName, string Phone, string CompanyName)
        {
            Customers customers = new Customers();
            customers.CustomerID = Id;
            customers.ContactName = ContactName;
            customers.Phone = Phone;
            customers.CompanyName = CompanyName;
            logic.Add(customers);
            return RedirectToAction("Index");
        }
        public ActionResult Modify(string Id)
        {
            Customers customers = logic.GetByID(Id);
            CustomersView customersView = new CustomersView();
            customersView.Id = customers.CustomerID;
            customersView.CompanyName = customers.CompanyName;
            customersView.ContactName = customers.ContactName;
            customersView.Phone = customers.Phone;
            return View(customersView);

        }

        public ActionResult ModifyAction(string Id, string ContactName, string Phone, string CompanyName)
        {
            Customers customers = new Customers
            {
                CustomerID = Id,
                ContactName = ContactName,
                Phone = Phone,
                CompanyName = CompanyName
            };
            logic.Modify(customers);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string Id)
        {
            logic.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}