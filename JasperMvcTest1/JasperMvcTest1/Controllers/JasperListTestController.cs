using JasperMvcTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace JasperMvcTest1.Controllers
{
    public class JasperListTestController : Controller
    {
        //
        // GET: /JasperListTest/

        JasperListTest.AuthorisationTransactionsWebService webService = new JasperListTest.AuthorisationTransactionsWebService();

        public ActionResult Index()
        {
            List<ZAUTHEAD> list = (List<ZAUTHEAD>)(new JavaScriptSerializer().Deserialize <List<ZAUTHEAD>>(webService.getZAUTHEAD(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "false", "TEST")));
            //String jasperSearchValue = 
            return View(list);
        }

        [HttpGet]
        public void JasperGetTest(String get)
        {
            Console.Write("Get");
        }

        [HttpPost]
        public void JasperPostTest(String test)
        {
            String value = test;
            Console.Write("Post");
        }

    }
}
