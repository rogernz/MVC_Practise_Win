using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCListBoxTrans.Models
{
    public class TweetViewModel
    {
        public Tweet Tweet { get; set; }
        public IList<Tweet> Tweets { get; set; }
    }
}