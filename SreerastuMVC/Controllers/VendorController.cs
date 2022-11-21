using Newtonsoft.Json;
using SreerastuMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SreerastuMVC.Controllers
{
    public class VendorController : Controller
    {
        Uri BaseUrl = new Uri("https://localhost:44366/api");
        HttpClient Client;
        public VendorController()
        {
            Client = new HttpClient();
            Client.BaseAddress = BaseUrl;
        }

        // GET: Vendor
        public ActionResult Index()
        {
            List<TBL_VendorStatus> VendorStatusInfo = new List<TBL_VendorStatus>();
            HttpResponseMessage response = Client.GetAsync(Client.BaseAddress + "/VendorStatus/GetVendorStatus").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                VendorStatusInfo = JsonConvert.DeserializeObject<List<TBL_VendorStatus>>(data);
            }
            return View(VendorStatusInfo);
        }

    }
}