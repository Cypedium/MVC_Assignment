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
            if (ModelState.IsValid) //Alltid kontrollera input på backend
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
        [HttpGet]
        public IActionResult Filter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Filter(string filterInput)
        {

            return View("Index", _personService.Filter(filterInput));
        }

        public IActionResult PersonList()
        {
            return PartialView(_personService.All());
        }
        [HttpGet]
        public IActionResult PersonPartialId(int id)
        {
            return PartialView("_PersonPartialId", _personService.Find(id));
        }
        [HttpGet]
        public IActionResult PersonCreatePartial()
        {
            return PartialView("_PersonCreatePartial");
        }

        [HttpPost]
        public IActionResult PersonCreatePartial(PersonViewModel personViewModel) //personViewModel uses to avoid users to access Id
        {
            if (ModelState.IsValid)
            {
            return PartialView("_AddToList", _personService.Create(personViewModel.Name, personViewModel.Country));
            }
            return View(personViewModel);
        }
        [HttpGet]
        public IActionResult PersonFilterPartial()
        {
            return PartialView("_PersonFilterPartial");
        }
        [HttpPost]
        public IActionResult PersonFilterPartial(string filterInput)
        {
            if (ModelState.IsValid)
            {
                return PartialView("_FilterListItem", _personService.Filter(filterInput));
            }
            return View(filterInput);
        }
        [HttpGet]
        public IActionResult PersonRenamePartial()
        {
            return PartialView("_PersonRenamePartial");
        }
        [HttpPost]
        public IActionResult PersonRenamePartial(PersonViewModel personViewModel, int id)
        {
            if (ModelState.IsValid)
            {
                return PartialView("_RenameListItem", _personService.Update(personViewModel)
));
            }
            return View(person); //Send person back with errormessage throug ModelState.IsValid
        }
    }
}