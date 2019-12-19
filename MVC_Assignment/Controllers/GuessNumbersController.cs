using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class GuessNumbersController : Controller
    {
        
        
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult Index(int name)
        //{
        //    return View();
        //}
        
        [HttpPost]
        public IActionResult Index(int random, string guessnumber)
        {
            try
            {
                if (string.IsNullOrEmpty(guessnumber))
                {
                    ViewBag.Msg = "The field needs a value";
                    return View();
                }

                else if (int.Parse(guessnumber) == 0)
                {
                    ViewBag.Msg = "You need to enter a number";
                    return View();
                }
                else
                {
                    if (int.Parse(guessnumber) > GuessNumber.random)
                    {
                        ViewBag.Msg = "Guess a lower number";
                    }
                    else if (int.Parse(guessnumber) < GuessNumber.random)
                    {
                        ViewBag.Msg = "Guess a higher number";
                    }
                    else
                    {
                        ViewBag.Msg = "Wow! You got the right answer";
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
