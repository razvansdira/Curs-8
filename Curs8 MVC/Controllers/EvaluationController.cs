using Curs8_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curs8_MVC.Controllers
{
    public class EvaluationController : Controller
    {

        public static List<ProjectEvaluation> ListOfProject = new List<ProjectEvaluation>
        {
            new ProjectEvaluation() {name="Mare", city = "Cluj", country="Romania", rating= 9.5 },
            new ProjectEvaluation() {name="Mic", city = "<script> alert('xss'); </script>", country="Romania", rating= 3.34 },
            new ProjectEvaluation() {name="Mediu", city = "Sibiu", country="Romania", rating= 7.8 }
        };

        // GET: Evaluation
        public ActionResult Index()
        {
            return View(ListOfProject);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
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

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluation/Edit/5
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

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
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
