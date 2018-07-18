using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCListBoxTrans.Models
{
    public class EmployViewModel
    {
        public IEnumerable<SelectListItem> empList { get; set; }
        public IEnumerable<SelectListItem> selectedEmp { get; set; }
    }
}