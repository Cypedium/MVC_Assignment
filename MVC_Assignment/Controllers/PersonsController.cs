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
        public IActionResult Create(PersonViewModel personViewModel) //personViewModel används för att inte få med id
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
            return View(personViewModel); //skickar med personViewModel för att kunna använda ModelState om någon required inte uppfylls
        }
        public IActionResult Remove(int id) //se en Person
        {         
                foreach (var item in Person.personList)
                {
                    if (item.Id == id)
                    { 
                        Person.personList.Remove(item);
                        break;
                    }
                   
                }
                return RedirectToAction("Index");   

        }
    }
}