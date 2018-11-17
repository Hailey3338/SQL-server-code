using System.Linq;
using System.Web.Mvc;
using Web.DataModel;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly XingEntities _context = new XingEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SearchUser(string searchName, int? searchAgeFrom, int? searchAgeTo, string searchHobby)
        {

            var users = _context.sp_SearchUser(searchName, searchAgeFrom, searchAgeTo, searchHobby).ToList();
            return View(users);
        }
        //[HttpGet]
        //public ActionResult SearchUser()
        //{
        //    return View();
        //}

    }
}