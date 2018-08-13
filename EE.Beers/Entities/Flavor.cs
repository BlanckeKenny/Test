using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EE.Beers.Entities
{
    public class Flavor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<BeerFlavor> BeersWithFlavor { get; set; }
    }
}
