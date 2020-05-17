using Store.Services;
using StoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreASP.Controllers
{
    public class ProductController : Controller
    {
        ProductServices productServices = new ProductServices();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = productServices.GetProducts();
            if (!string.IsNullOrEmpty(search))              //Nida işarəsi əvvəldə olduqda deyilsə əvəz edir
            {
                products = products.Where(pr => pr.Name.ToLower().Contains(search)).ToList();  
            }
            return PartialView(products);
        }
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productServices.SaveProduct(product);
            return RedirectToAction("ProductTable");
        }
        public ActionResult Edit(int ID)
        {
          var product= productServices.GetProduct(ID);
            return PartialView(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productServices.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }
        [HttpPost]
        public ActionResult Delete(int ID)
        { 
            productServices.DeleteProduct(ID);
            return RedirectToAction("ProductTable");
        }
    }
}