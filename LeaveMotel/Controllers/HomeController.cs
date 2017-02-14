using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using LeaveMotel.BusinessLayer.Services.Interfaces;

namespace LeaveMotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILeaveService _leaveService;

        public HomeController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }

        public IActionResult Index()
        {
            var x = _leaveService.GetLeaveCalandar(2015, Models.Enums.MonthName.January);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
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
