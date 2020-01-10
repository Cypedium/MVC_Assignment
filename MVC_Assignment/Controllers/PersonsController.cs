using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Models
{
    public class PersonsController : Controller
    {
        readonly PersonService _personService = new PersonService();
        public IActionResult Index() //List
        {
            return View(_personService.All());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PersonViewModel person) //personViewModel uses to avoid users to access Id
        {
            if (ModelState.IsValid)
            {
                _personService.Create(person.Name, person.Country);

                return RedirectToAction("Index");
            }
            return View(person); //personViewModel uses to sent wrong input to View 
        }
        public IActionResult Remove(int id) 
        {         
            bool result = _personService.Remove(id);

            if (result)
            { ViewBag.msg = "The person was successfully removed"; }
            else
            { ViewBag.msg = "The person could not be found"; }

            return View("Index", _personService.All());

        }
    }
}