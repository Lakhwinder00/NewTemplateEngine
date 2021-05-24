using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static TestApplication.Models.TemplateModel;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

           
            return View();
        }

        [HttpGet]
        public JsonResult GetHtml()
        {
            string FilePath = Server.MapPath("~/Scripts/Template/template.json");
            dynamic JasonSchemaFile = string.Empty;
            using (StreamReader r = new StreamReader(FilePath))
            {
                JasonSchemaFile = r.ReadToEnd();
            }
            return Json(JasonSchemaFile, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Template()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}