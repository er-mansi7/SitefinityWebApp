using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.DynamicModules.Builder;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Utilities.TypeConverters;

namespace SitefinityWebApp.MVC.Models
{
    public class OfficeModel
    {
        public Type OfficeType => TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Meettheteam.Office"); 
        // lesson 24
    }
}