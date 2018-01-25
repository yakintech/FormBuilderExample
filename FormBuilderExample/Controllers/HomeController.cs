using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormBuilderExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            inte
            for (int i = 0; i < collection.Count; i++)
            {
                string value = collection[i];
                string name = collection.Keys[i];
            }
            return Json("");
        }

        [ValidateInput(false)]
        public ActionResult HtmlSave(string content)
        {
            //html i db ye attı
            return Json("",JsonRequestBehavior.AllowGet);
        }


        public ActionResult CreateJsonobject(FormCollection collection)
        {
            var product = new JObject();
            for (int i = 0; i < collection.Count; i++)
            {
                string value = collection[i];
                string name = collection.Keys[i];
                product[name] = value;

            }
          
            return Json(product.ToString());
        }


        public ActionResult GetJsonObject()
        {
            var jsondata = "{\r\n  \"text-1515398092146\": \"aa\",\r\n  \"text-1515398093557\": \"ww\",\r\n  \"name\": \"Kayıt\"\r\n}";

            JObject json = JObject.Parse(jsondata);

            foreach (var item in json.Properties())
            {
                string name = item.Name;
                string value = item.Value.ToString();
               
            }

            return Json("");
        }
    }
}