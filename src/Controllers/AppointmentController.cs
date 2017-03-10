using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AllergySite.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TexasMedicalCenter()
        {
            return View();
        }

        public IActionResult theGalleria()
        {
            return View();
        }

        public IActionResult theWoodlands()
        {
            return View();
        }
    }
}