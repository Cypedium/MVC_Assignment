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
        public int RandomNumber()
        {
            Random random_ = new Random();
            return random_.Next(1, 100);  
        }
        
        public IActionResult Index()
        {
            int randomnumber=RandomNumber();
            HttpContext.Session.SetString("MyRandomNumber", randomnumber.ToString());
            return View();
        }
        //[HttpGet]
        //public IActionResult Index(int name)
        //{
        //    return View();
        //}
        
        [HttpPost]
        public IActionResult Index(string myGuess)
        {
            try
            {
                
                if (string.IsNullOrEmpty(myGuess))
                {
                    ViewBag.Msg = "The field needs a value";
                    return View();
                }

                else if (int.Parse(myGuess) == 0)
                {
                    ViewBag.Msg = "You need to enter a number";
                    return View();
                }
                else
                {
                    
                    string randomnumber = HttpContext.Session.GetString("MyRandomNumber");
                    if (int.Parse(myGuess) > int.Parse(randomnumber))
                    {
                        ViewBag.Msg = "Guess a lower number";
                    }
                    else if (int.Parse(myGuess) < int.Parse(randomnumber))
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
