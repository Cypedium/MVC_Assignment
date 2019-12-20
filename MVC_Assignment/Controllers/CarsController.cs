﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignment.Models;

namespace MVC_Assignment.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index() //List
        {
            return View(Car.carList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CarViewModel carViewModel)   
        {
            if (ModelState.IsValid)
            {
                Car.carList.Add(
                    new Car()
                    {
                        Brand = carViewModel.Brand,
                        ModelName = carViewModel.ModelName
                    });

                return RedirectToAction("Index");
            }
            return View(carViewModel);
        }
        public IActionResult Details() //se en bil
        {
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }
    }
}