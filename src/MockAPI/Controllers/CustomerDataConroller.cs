using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MockAPI.Controllers
{

    public class CustomerDataController : Controller
    {
        // GET: CustomerDataConroller
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerDataConroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerDataConroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerDataConroller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerDataConroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerDataConroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerDataConroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerDataConroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}