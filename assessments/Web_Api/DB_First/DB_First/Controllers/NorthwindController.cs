using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DB_First.Models;

namespace DB_First.Controllers
{
    public class NorthwindController : ApiController
    {
        NorthwindEntities1 db = new NorthwindEntities1();

        // 2. i) -- Order details of Steven Buchman

        [HttpGet]
        [Route("api/orders")]        
        public IHttpActionResult GetOrders()
        {
            var orders = db.Orders.Where(o => o.EmployeeID == 5).Select(o => new
            {
                EmployeeName = o.Employee.FirstName + " " + o.Employee.LastName,
                o.OrderID,                              
                o.CustomerID,
                o.OrderDate,
                o.ShipCountry
             }).ToList();

            return Ok(orders);
        }

        // 2. ii) ---- calling store procedure

        [HttpGet]
        [Route("api/customers/{country}")]
        public IHttpActionResult GetCustomers(string country)
        {
            var customers = db.GetCustomersByCountry(country);

            return Ok(customers);
        }
    }
}
