using Cinema.AppServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.UI.Admin.Controllers
{
    public class HallController : BaseController
    {
        // GET: Hall
        public ActionResult Index()
        {
            var halls = _hallService.GetAllNotDeleted();
            return View(halls);
        }

        // GET: Hall/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genre/Create
        [HttpPost]
        public ActionResult Create(HallDto hall)
        {
            try
            {
                _hallService.AddHall(hall);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Genre/Delete/5 
        public RedirectToRouteResult Delete(int id)
        {
            _hallService.DeleteHall(id);

            return RedirectToAction("Index");
        }
    }
}
