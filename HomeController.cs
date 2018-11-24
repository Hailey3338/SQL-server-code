using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebQuery.Models;

namespace WebQuery.Controllers
{
    public class HomeController : Controller
    {
        private readonly XingEntities _Context = new XingEntities();
        // GET: Home
        public ActionResult Index()
        {
            var results = _Context.Classes.Include(t => t.User).ToList();
            return View(results);
        }
    }
}