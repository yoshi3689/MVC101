using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mvc101.Controllers
{
    public class ProcesController : Controller
    {
        // GET: Proces
        public ActionResult Index()
        {
            // Process[] procs = Process.GetProcesses();
            return View(Process.GetProcesses());
        }

        public IActionResult Display(int id) {
    Process osProcess = Process.GetProcessById(id);
    return View(osProcess);
}



        // GET: Proces/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proces/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proces/Create
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

        // GET: Proces/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Proces/Edit/5
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

        // GET: Proces/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Proces/Delete/5
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