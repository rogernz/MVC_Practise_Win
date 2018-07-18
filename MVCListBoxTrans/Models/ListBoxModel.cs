using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCListBoxTrans.Models
{
    public class ListBoxModel
    {
        public List<item> LeftListBoxItems { get; set; }
        public List<item> RightListBoxItems { get; set; }

        public List<SelectListItem> LeftSelectedItems { get; set; }
        public int[] LeftSelectItemID { get; set; }

        public List<SelectListItem> RightSelectedItems { get; set; }
        public int[] RightSelectItemID { get; set; }

        public string SavedRightInfo { get; set; }
        public string SavedLeftInfo { get; set; }


    }


}