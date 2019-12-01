using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using net.Models;
using System.Threading;
using System.Web.Mvc;

namespace net.Repo
{
    public class ItemRepo
    {

        private resEntities objresEntities;
        public ItemRepo()
        {
            objresEntities = new resEntities();
        }
        public IEnumerable<SelectListItem> GetAllItem()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objresEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemId.ToString(),
                                      Selected = false,
                                  }).ToList();
            return objSelectListItems;
        }
    }

}