using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class CheckFeversController : Controller
    {
        [Route("FeverCheck")]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult Index(int name)
        //{
        //    return View();
        //}
        [Route("FeverCheck")]
        [HttpPost]
        public IActionResult Index(string info)
        {
            try
            {
                if (string.IsNullOrEmpty(info))
                {
                    ViewBag.Msg = "The field needs a value";
                    return View();
                }

                else if (int.Parse(info) == 0)
                {
                    ViewBag.Msg = "You need to enter a number";
                    return View();
                }
                else
                {
                    if (int.Parse(info) > 37)
                    {
                        ViewBag.Msg = "You got fever";
                    }
                    else
                    {
                        ViewBag.Msg = "You feeling fine";
                    }
                    return View();
                }
            }
            catch (FormatException)
            {
                ViewBag.Msg = "You need to enter a number";
                return View();
            }                                                
        }
    }
}