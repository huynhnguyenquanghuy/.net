using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using net.Controllers;
using net.Models;
using net.ViewModel;

namespace net.Repo
{
    public class OrderRepo
    {
        private resEntities objResEntities;
        public OrderRepo()
        {
            objResEntities = new resEntities();
        }

        public bool AddOrder(OrderViewModel objOrderViewModel)
        {
            Order objOrder = new Order();
            objOrder.CustomerId = objOrderViewModel.CustomerId;
            objOrder.FinalTotal = objOrderViewModel.FinalTotal;
            objOrder.OrderDate = DateTime.Now;
            objOrder.OrderNumber = String.Format("{0:ddmmmyyyyhhmmss}", DateTime.Now);
            objOrder.PaymentTypeId = objOrderViewModel.PaymentTypeId;
            objResEntities.Orders.Add(objOrder);
            objResEntities.SaveChanges();
            int OrderId = objOrder.OrderId;

            foreach(var item in objOrderViewModel.ListOfOrderDetailViewModel)
            {
                OrderDetail objOrderDetail = new OrderDetail();
                objOrderDetail.OrderId = OrderId;
                objOrderDetail.Discount = item.Discount;
                objOrderDetail.ItemId = item.ItemId;
                objOrderDetail.Price = item.Price;
                objOrderDetail.Total = item.Total;
                objOrderDetail.Quantity = item.Quantity;
                objResEntities.OrderDetails.Add(objOrderDetail);
                objResEntities.SaveChanges();


                Transaction objTransaction = new Transaction();
                objTransaction.ItemId = item.ItemId;
                objTransaction.Quantity =(-1)* item.Quantity;
                objTransaction.TransactionDate = DateTime.Now;
                objTransaction.TypeId = 2;
                objResEntities.Transactions.Add(objTransaction);
                objResEntities.SaveChanges();

            }
            return true;
        }
    }
}