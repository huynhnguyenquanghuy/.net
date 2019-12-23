using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace net.ViewModel
{
    public class OrderDetailViewModel
    {
        public int OrderDetailId { set; get; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

    }
}