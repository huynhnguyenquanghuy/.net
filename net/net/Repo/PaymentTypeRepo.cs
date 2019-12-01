using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Web.Mvc;
using net.Models;

namespace net.Repo
{
    public class PaymentTypeRepo
    {
        private resEntities objresEntities;


        public PaymentTypeRepo()
        {
            objresEntities = new resEntities();
        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objSelectListItems = new List<SelectListItem>();
             objSelectListItems = (from obj in objresEntities.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentTypeName,
                                      Value = obj.PaymentTypeId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;

        }
           

    }
}