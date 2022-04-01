using Admin.Data;
using Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class CustomerController : Controller
    {

        IUnitofWork<Customer> unitofWork;
        IModelRepo<Customer> ModelRepo;
        public CustomerController(IUnitofWork<Customer> _unitofWork)
        {
            unitofWork = _unitofWork;
            ModelRepo = unitofWork.GetRepo();
        }

        public ActionResult Index()
        {
            var cunstomers = ModelRepo.Read().ToList();
            return View(cunstomers);
        }

        // GET: CustomerController1/Details/5
        public ActionResult GetByID(int id)
        {
            Customer c = ModelRepo.GetByID(id);
            return View("CustomerDetails", c);
        }

        // GET: CustomerController1/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: CustomerController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            {
                ModelRepo.Create(c);
                unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Customer c)
        {
            try
            {
                ModelRepo.Update(c);
                unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Delete/5
        public ActionResult Delete(int id)
        {
            ModelRepo.Delete(id);
            return View();
        }
    }
}
