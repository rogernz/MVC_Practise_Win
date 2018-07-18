using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCListBoxTrans.Models
{
    public class item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public item(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public static List<item> GetAllItem()
        {
            List<item> list = new List<item>();
            for (int i = 1; i < 21; i++)
            {
                list.Add(new item(i, i.ToString()));
            }

            return list;
        }
    }
}