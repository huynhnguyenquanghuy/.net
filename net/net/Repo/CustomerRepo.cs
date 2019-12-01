using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using net.Models;

namespace net.Repo
{
    public class CustomerRepo
    {
        private resEntities objresEntities;
        public CustomerRepo()
        {
            objresEntities = new resEntities();
        }
        public IEnumerable<SelectListItem> GetAllCustomer()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objresEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}