using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers.extend
{
    [Authorize]
    public class AdminAccController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: AdminAcc
        public ActionResult Index()
        {
            
            var mod = db.Users.OrderBy(m => m.Id).ToList();
            return View(mod);
        }

        
        
    }
}