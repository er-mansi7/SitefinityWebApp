using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.MVC.ViewModel
{
    public class OfficeViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public ImageViewModel picture { get; set; } 
        public List<ImageViewModel> Gallery { get; set; }

    }
}