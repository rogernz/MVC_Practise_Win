using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCListBoxTrans.Models
{
    public class Tweet
    {
        public Tweet()
        {
            Date = DateTime.UtcNow;
        }
        private DateTime date;
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime Date
        {
            get { return date.ToLocalTime(); }
            set { date = value; }
        }


    }
}