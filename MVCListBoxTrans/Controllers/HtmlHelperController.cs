using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCListBoxTrans.Models;
using System.Text;

namespace MVCListBoxTrans.Controllers
{
    public class HtmlHelperController : Controller
    {
        // GET: HtmlHelper
        public ActionResult Index()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            for (int i = 1; i < 21; i++)
            {
                SelectListItem item = new SelectListItem();
                item.Value = i.ToString();
                item.Text = i.ToString();
                item.Selected = false;
                list.Add(item);

            }
            EmployViewModel EVM = new EmployViewModel();
            EVM.empList = list;
            return View(EVM);
        }

        public ActionResult GetResult(EmployViewModel model)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public string Index(FormCollection form)
        {
            if (null == null)
            {
                return "You have not selected any employee";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Selected employeeID " + string.Join(" ,", null));
                return sb.ToString();
            }
        }
    }
}