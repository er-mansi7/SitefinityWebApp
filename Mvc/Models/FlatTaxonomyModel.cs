using SitefinityWebApp.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;

namespace SitefinityWebApp.MVC.Models
{
    public class FlatTaxonomyModel
    {
        private readonly TaxonomyManager tm;
        private List<TaxaCount> taxaCounts = new List<TaxaCount>(); 
        public FlatTaxonomyModel()
        {
            this.tm = TaxonomyManager.GetManager();
            this.taxaCounts = this.tm.GetTaxa<FlatTaxon>().GroupBy(t => t.TaxonomyId)
                                .Select(g => new TaxaCount() { TaxonomyID = g.Key, Count = g.Count() })
                                .ToList();
        }

        public List<FlatTaxonomyViewModel> Taxonomies
        {
            private set;
            get;
        }
        
        public void Populate()
        {
            this.Taxonomies = this.tm.GetTaxonomies<FlatTaxonomy>()
                                    .Select(t => ToViewModel(t)).ToList();
        }

        private FlatTaxonomyViewModel ToViewModel(FlatTaxonomy taxonomy) 
        {
            var viewModel = new FlatTaxonomyViewModel();
            viewModel.Id = taxonomy.Id;
            viewModel.Name = taxonomy.Title.Value;

            var taxaCount = this.taxaCounts.FirstOrDefault(t => t.TaxonomyID == taxonomy.Id);
            viewModel.TaxaCount = taxaCount != null ? taxaCount.Count : 0;

            return viewModel;
        }

    }
}