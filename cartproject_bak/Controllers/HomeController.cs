using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cartproject.Models;

namespace cartproject.Controllers
{
    public class HomeController : Controller
    {
        mvcprojectEntities db = new mvcprojectEntities();

        public ActionResult Index()
        {
            
            var products = db.product.OrderBy(m => m.product_id).ToList();
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string product_id, string product_name, string product_title, string product_spec, decimal product_price, string product_description, string product_thumb, string product_image)
        {
            product prod = new product();
            prod.product_id = product_id;
            prod.product_name = product_name;
            prod.product_title = product_title;
            prod.product_spec = product_spec;
            prod.product_price = product_price;
            prod.product_description = product_description;
            prod.product_thumb = product_thumb;
            prod.product_image = product_image;

            db.product.Add(prod);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var prod = db.product.Where(m => m.id == id).FirstOrDefault();
            db.product.Remove(prod);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var prod = db.product.Where(m => m.id == id).FirstOrDefault();
            return View(prod);

        }

        [HttpPost]
        public ActionResult Edit(int id, string product_id, string product_name, string product_title, string product_spec, decimal product_price, string product_description, string product_thumb, string product_image)
        {
            var prod = db.product.Where(m => m.id == id).FirstOrDefault();
            prod.product_id = product_id;
            prod.product_name = product_name;
            prod.product_title = product_title;
            prod.product_spec = product_spec;
            prod.product_price = product_price;
            prod.product_description = product_description;
            prod.product_thumb = product_thumb;
            prod.product_image = product_image;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        //display targeted image
        public ActionResult ViewProduct(int id, string product_id, string product_name, string product_title, string product_spec, decimal product_price, string product_description, string product_thumb, string product_image)
        {
            var prod = db.product.Where(m => m.id == id).FirstOrDefault();
            prod.product_id = product_id;
            prod.product_name = product_name;
            prod.product_title = product_title;
            prod.product_spec = product_spec;
            prod.product_price = product_price;
            prod.product_description = product_description;
            prod.product_thumb = product_thumb;
            prod.product_image = product_image;
            

            

            return RedirectToAction("Index");

        }

        
    }
}