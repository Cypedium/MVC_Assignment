using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment.Models
{
    public class PersonsController : Controller
    {
        public IActionResult Index() //List
        {
            return View(Person.personList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PersonViewModel personViewModel) //personViewModel objekt som skapas tillfälligt
        {
            if (ModelState.IsValid)
            {
                Person.personList.Add(
                    new Person()
                    {
                        Name = personViewModel.Name,
                        Country = personViewModel.Country
                    });

                return RedirectToAction("Index");
            }
            return View(personViewModel);
        }
        public IActionResult Remove(PersonViewModel personViewModel, int data) //se en Person
        {
            if ( Person.personList.Contains(data))
            {
                Person.personList.Remove(data)
            }
            return View();
        }
        
    }
}