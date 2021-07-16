using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.MVC.Models
{
    public class TaxaCount
    {
        public Guid TaxonomyID { get; set; }
        public int Count { get; set; }
    }
}