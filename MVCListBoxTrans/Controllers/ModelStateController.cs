using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCListBoxTrans.Models;

namespace MVCListBoxTrans.Controllers
{
    public class ModelStateController : Controller
    {
        // GET: ModelState
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            AddUserVM ad = new AddUserVM();
            return View(ad);
        }
        [HttpPost]
        public ActionResult Add(AddUserVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            return RedirectToAction("Index");

        }
    }
}