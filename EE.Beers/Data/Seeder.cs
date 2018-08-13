using EE.Beers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EE.Beers.Data
{
    public class Seeder
    {
        public static void Seed(BeersContext context)
        {
            // Are there any products in the db?
            if (context.Beers.Any())
                return;   // DB has already been seeded

            var brouwerijen = new Brouwerij[]
            {
                new Brouwerij {Name = "West Brewco"},
                new Brouwerij {Name = "East Brewco"},
                new Brouwerij {Name = "South Brewco"},
                new Brouwerij {Name = "North Brewco"}
            };


            var beers = new Beer[]
            {
                new Beer { Name = "Ahool Ale",                 IsActivelyBrewed = true, BitteringIndex = 33, AlcoholByVolume = 5.4f,  Brouwerij = brouwerijen[0] },
                new Beer { Name = "Agogwe Ale",                IsActivelyBrewed = true, BitteringIndex = 28, AlcoholByVolume = 2.9f,  Brouwerij = brouwerijen[1] },
                new Beer { Name = "Aswang Ale",                IsActivelyBrewed = true, BitteringIndex = 31, AlcoholByVolume = 4.2f,  Brouwerij = brouwerijen[2] },
                new Beer { Name = "Buru's Barley Wine",        IsActivelyBrewed = true, BitteringIndex = 76, AlcoholByVolume = 11.1f, Brouwerij = brouwerijen[3] },
                new Beer { Name = "Hyote Chocolate Stout",     IsActivelyBrewed = true, BitteringIndex = 78, AlcoholByVolume = 7.4f,  Brouwerij = brouwerijen[0] },
                new Beer { Name = "Igopogo Pilsner",           IsActivelyBrewed = true, BitteringIndex = 36, AlcoholByVolume = 5.7f,  Brouwerij = brouwerijen[1] },
                new Beer { Name = "Jackalobe Lager",           IsActivelyBrewed = true, BitteringIndex = 29, AlcoholByVolume = 3.3f,  Brouwerij = brouwerijen[2] },
                new Beer { Name = "Mahamba Barley Wine",       IsActivelyBrewed = true, BitteringIndex = 57, AlcoholByVolume = 9.7f,  Brouwerij = brouwerijen[3] },
                new Beer { Name = "Megalodon Pale Ale",        IsActivelyBrewed = true, BitteringIndex = 99, AlcoholByVolume = 5.7f,  Brouwerij = brouwerijen[0] },
                new Beer { Name = "Pope Lick Porter",          IsActivelyBrewed = true, BitteringIndex = 39, AlcoholByVolume = 6.5f,  Brouwerij = brouwerijen[1] },
                new Beer { Name = "Chocolate Pukwudgie Stout", IsActivelyBrewed = true, BitteringIndex = 35, AlcoholByVolume = 12.2f, Brouwerij = brouwerijen[2] },
                new Beer { Name = "Sharlie Pilsner",           IsActivelyBrewed = true, BitteringIndex = 31, AlcoholByVolume = 4.1f,  Brouwerij = brouwerijen[3] },
                new Beer { Name = "Sigbin Stout",              IsActivelyBrewed = false,BitteringIndex = 65, AlcoholByVolume = 8.1f,  Brouwerij = brouwerijen[0] },
                new Beer { Name = "Snallygaster Pale Ale" ,    IsActivelyBrewed = false,BitteringIndex = 89, AlcoholByVolume = 9.7f,  Brouwerij = brouwerijen[1] },
                new Beer { Name = "Tikibalang Barley Wine",    IsActivelyBrewed = true, BitteringIndex = 45, AlcoholByVolume = 9.6f,  Brouwerij = brouwerijen[2] },
                new Beer { Name = "Pale Popobawa Ale",         IsActivelyBrewed = true, BitteringIndex = 30, AlcoholByVolume = 4.4f,  Brouwerij = brouwerijen[3] },
                new Beer { Name = "North Adjule Lager",        IsActivelyBrewed = true, BitteringIndex = 30, AlcoholByVolume = 3.7f,  Brouwerij = brouwerijen[0] },
            };

            var flavors = new Flavor[]
            {
                /*  0 */ new Flavor { Name = "biscuity" },
                /*  1 */ new Flavor { Name = "floral" },
                /*  2 */ new Flavor { Name = "butter" },
                /*  3 */ new Flavor { Name = "yeast" },
                /*  4 */ new Flavor { Name = "raisin" },
                /*  5 */ new Flavor { Name = "dried fruit" },
                /*  6 */ new Flavor { Name = "bourbon" },
                /*  7 */ new Flavor { Name = "caramel" },
                /*  8 */ new Flavor { Name = "chocolate" },
                /*  9 */ new Flavor { Name = "malt" },
                /* 10 */ new Flavor { Name = "fruit" },
                /* 11 */ new Flavor { Name = "citrus" },
                /* 12 */ new Flavor { Name = "hops" },
                /* 13 */ new Flavor { Name = "pine" },
                /* 14 */ new Flavor { Name = "smokey" },
                /* 15 */ new Flavor { Name = "banana" },
                /* 16 */ new Flavor { Name = "coffee" },
                /* 17 */ new Flavor { Name = "grass" },
                /* 18 */ new Flavor { Name = "honey" },
                /* 19 */ new Flavor { Name = "wheat" },
                /* 20 */ new Flavor { Name = "bread" },
            };

            var beerflavors = new BeerFlavor[]
            {
                new BeerFlavor { Beer = beers[0],  Flavor = flavors[0]  },
                new BeerFlavor { Beer = beers[1],  Flavor = flavors[1]  },
                new BeerFlavor { Beer = beers[1],  Flavor = flavors[19] },
                new BeerFlavor { Beer = beers[2],  Flavor = flavors[2]  },
                new BeerFlavor { Beer = beers[2],  Flavor = flavors[3]  },
                new BeerFlavor { Beer = beers[3],  Flavor = flavors[4]  },
                new BeerFlavor { Beer = beers[3],  Flavor = flavors[5]  },
                new BeerFlavor { Beer = beers[3],  Flavor = flavors[6]  },
                new BeerFlavor { Beer = beers[4],  Flavor = flavors[7]  },
                new BeerFlavor { Beer = beers[4],  Flavor = flavors[8]  },
                new BeerFlavor { Beer = beers[5],  Flavor = flavors[9]  },
                new BeerFlavor { Beer = beers[5],  Flavor = flavors[20] },
                new BeerFlavor { Beer = beers[6],  Flavor = flavors[10] },
                new BeerFlavor { Beer = beers[6],  Flavor = flavors[11] },
                new BeerFlavor { Beer = beers[7],  Flavor = flavors[9]  },
                new BeerFlavor { Beer = beers[7],  Flavor = flavors[4]  },
                new BeerFlavor { Beer = beers[8],  Flavor = flavors[20] },
                new BeerFlavor { Beer = beers[8],  Flavor = flavors[12] },
                new BeerFlavor { Beer = beers[8],  Flavor = flavors[13] },
                new BeerFlavor { Beer = beers[9],  Flavor = flavors[14] },
                new BeerFlavor { Beer = beers[9],  Flavor = flavors[15] },
                new BeerFlavor { Beer = beers[9],  Flavor = flavors[8]  },
                new BeerFlavor { Beer = beers[10], Flavor = flavors[8]  },
                new BeerFlavor { Beer = beers[10], Flavor = flavors[16] },
                new BeerFlavor { Beer = beers[11], Flavor = flavors[17] },
                new BeerFlavor { Beer = beers[12], Flavor = flavors[16] },
                new BeerFlavor { Beer = beers[12], Flavor = flavors[7]  },
                new BeerFlavor { Beer = beers[13], Flavor = flavors[13] },
                new BeerFlavor { Beer = beers[13], Flavor = flavors[18] },
                new BeerFlavor { Beer = beers[14], Flavor = flavors[6]  },
                new BeerFlavor { Beer = beers[15], Flavor = flavors[19] },
                new BeerFlavor { Beer = beers[16], Flavor = flavors[11] },
            };
            
            context.Beers.AddRange(beers);
            context.Set<BeerFlavor>().AddRange(beerflavors);
            context.SaveChanges();
        }
    }
}
