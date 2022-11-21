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
    public class SubstriptionController : Controller
    {
        Uri BaseUrl = new Uri("https://localhost:44366/api");
        HttpClient Client;
        public SubstriptionController()
        {
            Client = new HttpClient();
            Client.BaseAddress = BaseUrl;
        }

        // GET: SubstriptionType
        public ActionResult Index()
        {
            List<TBL_SubscriptionType> subscriptionTypeInfo = new List<TBL_SubscriptionType>();
            HttpResponseMessage response = Client.GetAsync(Client.BaseAddress + "/SubstriptionType/GetSubscriptionType").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                subscriptionTypeInfo = JsonConvert.DeserializeObject<List<TBL_SubscriptionType>>(data);
            }
            return View(subscriptionTypeInfo);
        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(TBL_SubscriptionType model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = Client.PostAsync(Client.BaseAddress + "/SubstriptionType/AddSubscriptionType", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int ID)
        {
            TBL_SubscriptionType Model = new TBL_SubscriptionType();
            HttpResponseMessage response = Client.GetAsync(Client.BaseAddress + "/SubstriptionType/GetSubscriptionTypes?id=" + ID).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                Model = JsonConvert.DeserializeObject<TBL_SubscriptionType>(data);
            }
            return View("Edit", Model);
        }
        [HttpPost]
        public ActionResult Edit(TBL_SubscriptionType Model)
        {
            string data = JsonConvert.SerializeObject(Model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = Client.PostAsync(Client.BaseAddress + "/SubstriptionType/UpdateSubscriptionType" , content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View(Model);
        }
       
    }
}