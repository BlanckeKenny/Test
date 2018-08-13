using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EE.Beers.Entities
{
    public class Brouwerij
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
            
        public ICollection<Beer> BierenVanBrouwerij { get; set; }

    }
}
