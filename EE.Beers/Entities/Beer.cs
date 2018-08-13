using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EE.Beers.Entities
{
    public class Beer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActivelyBrewed { get; set; }
        public byte BitteringIndex { get; set; }
        public float AlcoholByVolume { get; set; }
        
        public ICollection<BeerFlavor> Flavors { get; set; }

    }
}
