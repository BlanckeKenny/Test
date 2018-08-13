using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EE.Beers.Entities
{
    public class BeerFlavor
    {
        public long BeerId { get; set; }
        public long FlavorId { get; set; }

        public Beer Beer { get; set; }
        public Flavor Flavor { get; set; }
    }
}
