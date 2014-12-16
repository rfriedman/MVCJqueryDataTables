using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCJqueryDataTables.Models;

namespace MVCJqueryDataTables.Controllers
{
    public class HomeController : Controller
    {
        private CustomerListDataContext _dataModel;
        public HomeController()
        {
            _dataModel = new CustomerListDataContext();
        }

        public ActionResult Index()
        {
            return View(_dataModel.Customers.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}