using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment.Controllers
{
    public class SessionsController : Controller
    {
        public IActionResult LookAt()
        {
            ViewBag.Msg2 = HttpContext.Session.GetString("KeyName");
            return View();
        }
        public IActionResult SaveSession(string message)
        {
            HttpContext.Session.SetString("KeyName", message);
            return RedirectToAction("LookAt");
        }
    }
}