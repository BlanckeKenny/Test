using EE.Beers.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EE.Beers.ViewModels
{
    public class BeersCreateVm
    {
        [Required]
        public float AlcoholByVolume { get; set; }

        [Required]
        public byte BitteringIndex { get; set; }

        [Required]
        public string Name { get; set; }

        public bool ActiveBrewed { get; set; }

        public long? BrouwerID { get; set; }
        public IEnumerable<Brouwerij> BeschikbareBrowuers { get; set; }
    }
}
