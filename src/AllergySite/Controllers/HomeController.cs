using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AllergySite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public IActionResult Physicians()
        {
            ViewData["Message"] = "Physicians";

            return View();
        }

        public IActionResult Offices()
        {
            ViewData["Message"] = "Offices";

            return View();
        }

        public IActionResult Services()
        {
            ViewData["Message"] = "Conditions we Treat";

            return View();
        }

        public IActionResult NewPatient()
        {
            ViewData["Message"] = "New to the Practice?";

            return View();
        }

        public IActionResult PollenMap()
        {
            ViewData["Message"] = "Pollen Levels in Your Area.";

            return View();
        }

        public IActionResult AppointmentForm()
        {
            ViewData["Message"] = "Schedule an Appointment!";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
