using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TP4.EF.API.Models;
using TP4.EF.Entities;
using TP4.EF.Logic;

namespace TP4.EF.API.Controllers
{
    public class CustomersController : ApiController
    {
       CustomersLogic customersLogic = new CustomersLogic();
        public IHttpActionResult Get()
        {
            try
            {
                List<Customers> customers = customersLogic.GetAll();
                List<CustomersView> customersView = customers.Select(c => new CustomersView
                {
                    Id = c.CustomerID.Trim(),
                    ContactName = c.ContactName,
                    Phone = c.Phone
                }).ToList();

                return Ok(customersView);
            }
            catch
            {
                return InternalServerError();
            }
        }

        public IHttpActionResult Get(string id)
        {
            try
            {
                Customers customer = customersLogic.GetByID(id);
                if (customer != null)
                {
                    CustomersView customersView = new CustomersView
                    {
                        Id = customer.CustomerID.Trim(),
                        ContactName = customer.ContactName,
                        Phone = customer.Phone
                    };
                    return Ok(customersView);
                }
                else return NotFound();
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] CustomersView customersView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Customers customers = new Customers
                    {
                        CustomerID = customersView.Id.Trim(),
                        ContactName = customersView.ContactName,
                        Phone = customersView.Phone,
                        CompanyName = customersView.CompanyName
                    };
                    
                    customersLogic.Add(customers);
                    return Ok();
                }
                catch
                {
                    return InternalServerError();
                }
            }
            else return BadRequest(ModelState);
        }

        public IHttpActionResult Put([FromBody] CustomersView customersView)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Customers customers = new Customers
                    {

                        CustomerID = customersView.Id.Trim(),
                        ContactName = customersView.ContactName,
                        Phone = customersView.Phone,
                        CompanyName = customersView.CompanyName
                    };
                        
                    customersLogic.Modify(customers);
                    return Ok();
                }
                catch
                {
                    return InternalServerError();
                }
            }
            else
                return BadRequest(ModelState);
        }
        public IHttpActionResult Delete(string id)
        {
            try
            {
                customersLogic.Delete(id);
                return Ok();
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}