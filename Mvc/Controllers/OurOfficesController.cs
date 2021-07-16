using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.MVC.Controllers
{
    [ControllerToolboxItem (Name ="OurOfficeWidget", Title ="Our Offices", SectionName = "Custom")]
    public class OurOfficesController : Controller
    {
        // lesson 24
        // GET: OurOffices
        public ActionResult Index()
        {
            return View();
        }
    }
}