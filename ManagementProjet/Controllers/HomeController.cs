using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagementProjet.Models;
using Microsoft.AspNetCore.Authorization;
using ManagementProjet.Data;
using Microsoft.AspNetCore.Identity;

namespace ManagementProjet.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
           return View();
        }  
          
        [HttpGet]
        public IActionResult Index(int totalVehicule, int TotalAgence, int TotalPersonnel,int user)
        {
            ViewBag.TotalVehicule = _context.Vehicule.Count();
            ViewBag.TotalAgence = _context.Agence.Count();
            ViewBag.TotalPersonnel = _context.Personnel.Count();
            ViewBag.User = userManager.Users.Count();
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



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
