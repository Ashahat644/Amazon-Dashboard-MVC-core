using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IUnitofWork<Admins> UnitOfWork;
        IModelRepo<Admins> AdminRepo;

        public HomeController(ILogger<HomeController> logger , IUnitofWork<Admins> _UnitOfWork)
        {
            _logger = logger;
            UnitOfWork = _UnitOfWork;
            AdminRepo = UnitOfWork.GetRepo();
        }

        public IActionResult Index()
        {
            var admins = AdminRepo.Read().ToList();
            return View("index" , admins);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
