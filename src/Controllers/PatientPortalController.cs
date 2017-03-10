using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AllergySite.Controllers
{
    public class PatientPortalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UpdateInformation()
        {
            return View();
        }

        public IActionResult MyDocuments()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {
            return View();
        }

        public IActionResult AppointmentForm()
        {
            return View();
        }

        public IActionResult AppointmentSubmitted()
        {
            return View();
        }
    }
}