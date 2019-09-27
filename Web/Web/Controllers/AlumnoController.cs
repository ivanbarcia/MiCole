using System.Linq;
using System.Web.Mvc;
using Web.BLL.Interfaces;
using Web.DAL.Models;

namespace Web.Controllers
{
    public class AlumnoController : Controller
    {
        public readonly IAlumnoBusiness _alumnoBusiness;

        public AlumnoController(IAlumnoBusiness alumnoBusiness)
        {
            _alumnoBusiness = alumnoBusiness;
        }

        //[Authorize]
        public ActionResult Index()
        {
            var alumnos = _alumnoBusiness.GetAll().ToList();
            return View(alumnos);
        }

        public ActionResult Details(int id = 0)
        {
            var alumno = _alumnoBusiness.Find(id);

            if (alumno == null)
            {
                return HttpNotFound();
            }

            return View(alumno);
        }

        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _alumnoBusiness.Insert(alumno);

                string url = Url.Action("Index", "Alumno");
                return Json(new { success = true, url = url });
            }

            return PartialView(alumno);
        }

        public ActionResult Edit(int id = 0)
        {
            var alumno = _alumnoBusiness.Find(id);

            if (alumno == null)
            {
                return HttpNotFound();
            }

            return PartialView(alumno);
        }

        [HttpPost]
        public ActionResult Edit(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                _alumnoBusiness.Update(alumno);

                string url = Url.Action("Index", "Alumno");
                return Json(new { success = true, url = url });
            }

            return PartialView(alumno);
        }

        public ActionResult Delete(int id = 0)
        {
            var alumno = _alumnoBusiness.Find(id);

            if (alumno == null)
            {
                return HttpNotFound();
            }

            return PartialView(alumno);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var alumno = _alumnoBusiness.Find(id);

            _alumnoBusiness.Delete(alumno);

            string url = Url.Action("Index", "Allumno");
            return Json(new { success = true, url = url });
        }
    }
}