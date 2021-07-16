using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.MVC.ViewModel
{
    public class ImageViewModel
    {
        public Guid Id { get; set; }
        public string ProviderName { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
    }
}