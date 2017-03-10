using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AllergySite.Controllers
{
    public class ConditionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult allergicRhinitis()
        {
            return View();
        }

        public IActionResult nonallergicRhinitis()
        {
            return View();
        }

        public IActionResult asthma()
        {
            return View();
        }

        public IActionResult sinusitus()
        {
            return View();
        }

        public IActionResult skinDisease()
        {
            return View();
        }

        public IActionResult foodAllergy()
        {
            return View();
        }

        public IActionResult venom()
        {
            return View();
        }

        public IActionResult anaphylaxis()
        {
            return View();
        }
    }
}