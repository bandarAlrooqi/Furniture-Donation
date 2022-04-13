using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET
{
    public class Component
    {
        public static bool IsLogedIn = false;
        public static user user = null;
        public static string currentItem = null;
        //public static good requested = null;
        //public static good deleted = null;
        //public static List<good> goods = new List<good>();
        //public static void SaveChangesGoods()
        //{
        //    using(var entity = new donationEntities())
        //    {
        //        foreach(var item in goods)
        //        {
        //            var i = entity.goods.FirstOrDefault(e=>e.Id == item.Id);
        //            i.Status = item.Status;
        //            i.RequestedBy = item.RequestedBy;
        //        }
        //        entity.SaveChanges();
        //    }
        //}


    }
}