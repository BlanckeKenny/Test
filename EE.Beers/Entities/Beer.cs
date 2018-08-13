using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EE.Beers.Entities
{
    public class Beer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActivelyBrewed { get; set; }
        public byte BitteringIndex { get; set; }
        public float AlcoholByVolume { get; set; }

        public Brouwerij Brouwerij { get; set; }
        
        public ICollection<BeerFlavor> Flavors { get; set; }

    }
}
