using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_project.Models;

namespace MVC_project.Controllers
{
    public class HappyController : Controller
    {
        //
        // GET: /Happy/

        public ActionResult abc()
        {
            Student alex = new Student();
            alex.FirstName = "Alex";
            alex.LastName = "stupid";
            return View(alex);
        }

        public ActionResult Index()
        {

            return View();

        }





    }
}
