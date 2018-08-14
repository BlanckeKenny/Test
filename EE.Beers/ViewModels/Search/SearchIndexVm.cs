using EE.Beers.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EE.Beers.ViewModels
{
    public class SearchIndexVm
    {
        [Required]
        public decimal MinAlc { get; set; }

        [Required]
        public decimal MaxAlc { get; set; }

        [Required]
        public string StartWith { get; set; }

        
        public bool ActiveBrewed { get; set; }  

        public IEnumerable<Beer> Bieren { get; set; }
    }
}
