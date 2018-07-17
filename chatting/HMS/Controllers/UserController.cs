using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Controllers
{
    public class UserController : Controller
    {
        private UserRepository urepo = new UserRepository();
        // GET: User
        public ActionResult Index()
        {
            return View(this.urepo.GetAll().ToList());
        }
    }
}