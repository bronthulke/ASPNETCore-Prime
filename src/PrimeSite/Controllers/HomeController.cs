using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prime.Services;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly PrimeService _primeService; 
        public HomeController() 
        { 
            _primeService = new PrimeService(); 
        } 
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Prime()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Prime(PrimeViewModel vm)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.Message = "Invalid data passed";
                return View();
            }

            bool isPrime = _primeService.IsPrime(vm.Value);
            ViewBag.Message = $"Value {vm.Value} {(isPrime ? "is" : "is not")} a prime number.";

            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
