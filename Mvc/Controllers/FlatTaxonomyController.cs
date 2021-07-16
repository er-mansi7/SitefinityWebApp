using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.MVC.Models;

namespace SitefinityWebApp.MVC.Controllers
{
    [ControllerToolboxItem(Name ="Flat Taxonomies", 
                            Title ="Flat Taxonomies", 
                            SectionName ="Classifications" )]
    public class FlatTaxonomyController : Controller
    {
        // GET: FlatTaxonomy
        public ActionResult Index()
        {
            var model = new FlatTaxonomyModel();
            model.Populate();
            return View("Index",model);
        }
    }
}