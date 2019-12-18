using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class FeversController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FeverList = Fever.feversList;

            return View();
        }
        [HttpGet] //skapar form
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //postar 
        public IActionResult Create(string info)
        {
            if (string.IsNullOrEmpty(info))
            {
                ViewBag.Msg = "You must enter some text.";
                return View();
            }
            else
            {
                Fever.feversList.Add(new Fever() { Info = info });

                return RedirectToAction("Index");
            }

        }
    }
}