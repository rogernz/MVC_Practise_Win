using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCListBoxTrans.Models;
namespace MVCListBoxTrans.Controllers
{
    public class TweetController : Controller
    {
        // GET: Tweet
        public ActionResult Index()
        {
            TweetViewModel tvm = new TweetViewModel();
            tvm.Tweets = new List<Tweet>();
            return View(tvm);
        }

        [HttpPost]
        public PartialViewResult AddTweet(Models.TweetViewModel viewModel)
        {

            if (viewModel.Tweets == null)
            {
                viewModel.Tweets = new List<Tweet>();
            }
            viewModel.Tweets.Add(viewModel.Tweet);
            return PartialView("_AllTweets", viewModel);

        }





    }
}