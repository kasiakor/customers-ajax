using CustomersAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomersAjax.Controllers
{
    public class CustomerController : Controller
    {
        //get data, no db, hard-coded
        //define data for the app, customer object
        Customer customer;
        List<Customer> customers;


        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Gia", 34));
            customers.Add(new Customer(1, "Brad", 23));
            customers.Add(new Customer(2, "Charles", 48));
            customers.Add(new Customer(3, "Daniel", 12));
            customers.Add(new Customer(4, "Evelyn", 85));
            customers.Add(new Customer(5, "Frank", 58));
            customers.Add(new Customer(6, "Anna", 3));
        }
        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[2]);

            //tuple - object model
            return View("Customer", tuple);
        }
    }
}