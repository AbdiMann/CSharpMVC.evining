using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEvening.Models;
using MVCEvening.ViewModels;


namespace MVCEvening.Controllers
{
    public class MainController : Controller
    {
        // GET: Main

        CustomerForm customerForm = new CustomerForm();
        Repository _repository = new Repository();


        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CustomerForm customerForm)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult CustomersList()
        {
            var myCustomerList = customerForm.GetPersonInfo();
            return View(myCustomerList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerForm customerForm)
        {
            if (ModelState.IsValid)
            {
                _repository.Create(customerForm);
            }
            return View();
        }

    }
}