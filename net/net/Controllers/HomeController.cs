using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using net.Models;
using net.Repo;
using net.ViewModel;

namespace net.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private resEntities objresEntities;
        private OrderViewModel objorderViewModel;

        public HomeController()
        {
            objresEntities = new resEntities();
        }

        public ActionResult Index()
        {
            CustomerRepo objCustomerRepo = new CustomerRepo();
            ItemRepo objItemRepo = new ItemRepo();
            PaymentTypeRepo objPaymentTypeRepo = new PaymentTypeRepo();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
            (objCustomerRepo.GetAllCustomer(), objItemRepo.GetAllItem(), objPaymentTypeRepo.GetAllPaymentType());
            return View(objMultipleModels);
        }
        [HttpGet]
        public JsonResult getItemPrice(int itemId)
        {
            decimal unitPrice = objresEntities.Items.Single(model => model.ItemId == itemId).ItemPirce;
            return Json(unitPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(OrderViewModel objoderViewModel)
        {
            OrderRepo objorderRepo = new OrderRepo();
            objorderRepo.AddOrder(objorderViewModel);
            return Json(data: "oke", JsonRequestBehavior.AllowGet);
        }
    }
}