﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.MVC.ViewModel
{
    public class FlatTaxonomyViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int TaxaCount { get; set; }
    }
}