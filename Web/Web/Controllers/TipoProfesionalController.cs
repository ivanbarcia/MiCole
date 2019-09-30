using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class TipoProfesionalController : BaseController
    {
        // GET: TipoProfesional
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoProfesional/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoProfesional/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoProfesional/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoProfesional/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoProfesional/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoProfesional/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoProfesional/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
