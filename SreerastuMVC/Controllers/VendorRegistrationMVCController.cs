using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SreerastuMVC.Models;
using System.Net.Http;
using Newtonsoft.Json;


namespace SreerastuMVC.Controllers
{
    public class VendorRegistrationMVCController : Controller
    {
        SreerastuEntities1 db = new SreerastuEntities1();
        Uri BaseUrl = new Uri("https://localhost:44348/api");
        HttpClient Client;
        public VendorRegistrationMVCController()
        {
            Client = new HttpClient();
            Client.BaseAddress = BaseUrl;
        }

        // GET: VendorRegistrationMVC
        public ActionResult Index()
        {
            List<TBL_VendorRegistration> vendorInfo = new List<TBL_VendorRegistration>();
            HttpResponseMessage response = Client.GetAsync(Client.BaseAddress + "/VendorRegistration/GetVendor").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                vendorInfo = JsonConvert.DeserializeObject<List<TBL_VendorRegistration>>(data);
            }
            return View(vendorInfo);
        }
        public ActionResult Insert()
        {
            var CategoryList = db.TBL_VendorCategory.ToList();
            ViewBag.VendorCategory = CategoryList;
            return View();   
        }
        [HttpPost]
        public ActionResult Insert(TBL_VendorRegistration model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = Client.PostAsync(Client.BaseAddress + "/VendorRegistration/AddVendor", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult Update(int id)
        {
            TBL_VendorRegistration vendorDetails = new TBL_VendorRegistration();
            HttpResponseMessage response = Client.GetAsync(Client.BaseAddress + "/VendorRegistration/GetVendorByID?vendorID=" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                vendorDetails = JsonConvert.DeserializeObject<TBL_VendorRegistration>(data);
            }
            return View(vendorDetails);
        }
        [HttpPost]
        public ActionResult Update(TBL_VendorRegistration model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = Client.PostAsync(Client.BaseAddress + "/VendorRegistration/UpdateVendor", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Update", model);
        }
    }
}