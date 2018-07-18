using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCListBoxTrans.Models;


namespace MVCListBoxTrans.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ListBoxModel model = new ListBoxModel { LeftListBoxItems = item.GetAllItem(), RightListBoxItems = new List<item>() };
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(ListBoxModel model, string ToRight, string ToLeft)
        {
            ModelState.Clear();
            //To get the two list box items' information
            RestoreSavedState(model);
            if (ToRight != null)
            {
                MoveToRight(model);
            }
            else
            {
                MoveToLeft(model);
            }
            sortBoxList(model);
            //To Save the two list box items' information
            SaveState(model);
            return View(model);
        }

        public void sortBoxList(ListBoxModel model)
        {
            model.RightListBoxItems = model.RightListBoxItems.OrderBy(p => p.Name.Length).ThenBy(p => p.Name).ToList();
            model.LeftListBoxItems = model.LeftListBoxItems.OrderBy(p => p.Name.Length).ThenBy(p => p.Name).ToList();

        }
        void SaveState(ListBoxModel model)
        {
            //create comma delimited list of item ids
            model.SavedRightInfo = string.Join(",", model.RightListBoxItems.Select(p => p.Id.ToString()).ToArray());
            model.SavedLeftInfo = string.Join(",", model.LeftListBoxItems.Select(p => p.Id.ToString()).ToArray());

        }

        void MoveToRight(ListBoxModel model)
        {
            if (model.LeftSelectItemID != null)
            {
                var prods = item.GetAllItem().Where(p => model.LeftSelectItemID.Contains(p.Id));
                model.RightListBoxItems.AddRange(prods);


                model.LeftListBoxItems.RemoveAll(p => model.LeftSelectItemID.Contains(p.Id));
                model.LeftSelectItemID = null;
            }
        }
        void MoveToLeft(ListBoxModel model)
        {
            if (model.RightSelectItemID != null)
            {

                var prods = item.GetAllItem().Where(p => model.RightSelectItemID.Contains(p.Id));
                model.LeftListBoxItems.AddRange(prods);

                model.RightListBoxItems.RemoveAll(p => model.RightSelectItemID.Contains(p.Id));
                model.RightSelectItemID = null;
            }
        }
        void RestoreSavedState(ListBoxModel model)
        {
            model.RightListBoxItems = new List<item>();
            model.LeftListBoxItems = new List<item>();
            //get the previously stored items
            if (!string.IsNullOrEmpty(model.SavedRightInfo) && !string.IsNullOrEmpty(model.SavedLeftInfo))
            {
                string[] itemIds = model.SavedRightInfo.Split(',');
                var prods = item.GetAllItem().Where(p => itemIds.Contains(p.Id.ToString()));
                model.RightListBoxItems.AddRange(prods);


                itemIds = model.SavedLeftInfo.Split(',');
                prods = item.GetAllItem().Where(p => itemIds.Contains(p.Id.ToString()));
                model.LeftListBoxItems.AddRange(prods);

            }
            else
            {
                model.LeftListBoxItems = item.GetAllItem();
            }
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


    }
}