using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCListBoxTrans.Models;

namespace MVCListBoxTrans.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public JsonResult AjaxMethod(PersonModel person)
        {
            int personId = person.PersonId;
            string name = person.Name;
            string gender = person.Gender;
            string city = person.City;
            return Json(person);
        }
        [HttpPost]
        public PartialViewResult ShowResult(PersonModel person)
        {


            return PartialView("_PersonShow", person);

        }
    }
}