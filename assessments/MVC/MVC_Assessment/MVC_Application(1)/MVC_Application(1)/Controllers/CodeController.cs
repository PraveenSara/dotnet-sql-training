using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Application_1_.Models;

namespace MVC_Application_1_.Controllers
{
    public class CodeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Code
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GermanyCostumer()
        {
            var customers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(customers);
        }

        public ActionResult FindCustomerByOrder()
        {
            var customers = db.Orders.Where(f => f.OrderID == 10248).Select(o => o.Customer).FirstOrDefault();
            return View(customers);
        }
    }
}