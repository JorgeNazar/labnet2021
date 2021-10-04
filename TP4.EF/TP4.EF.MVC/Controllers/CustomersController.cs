﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            try
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
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Insert()
        {
            return View("Insert");
        }
        public ActionResult InsertAction(string Id, string ContactName, string Phone, string CompanyName)
        {
            try
            {
                Customers customers = new Customers();
                customers.CustomerID = Id;
                customers.ContactName = ContactName;
                customers.Phone = Phone;
                customers.CompanyName = CompanyName;
                logic.Add(customers);
                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
        public ActionResult Modify(string Id)
        {
            try
            {
                Customers customers = logic.GetByID(Id);

                CustomersView customersView = new CustomersView { 
                    Id = customers.CustomerID,
                    CompanyName = customers.CompanyName,
                    ContactName = customers.ContactName,
                    Phone = customers.Phone
                };
                return View(customersView);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }

        }

        public ActionResult ModifyAction(string Id, string ContactName, string Phone, string CompanyName)
        {
            try
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
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(string Id)
        {
            try
            {
                logic.Delete(Id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }
    }
}