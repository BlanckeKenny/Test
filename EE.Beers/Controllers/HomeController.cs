using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EE.Beers.Entities;
using EE.Beers.Data;
using EE.Beers.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace EE.Beers.Controllers
{
    public class HomeController : Controller
    {
        BeersContext context;

        public HomeController(BeersContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeIndexVm indexvm = new HomeIndexVm();
            indexvm.Beers = await context.Beers
                .Include(b => b.Flavors)
                .ThenInclude(fl => fl.Flavor)
                .OrderBy(e => e.Name)
                .ToListAsync();
            return View(indexvm);
        }
        
        public async Task<IActionResult> FindByFlavor(long id)
        {
            var flavor = await context.Flavors
                .Include(f => f.BeersWithFlavor)
                .ThenInclude(bfl => bfl.Beer)
                .ThenInclude(b => b.Flavors)
                .ThenInclude(bf => bf.Flavor)
                .FirstOrDefaultAsync(f => f.Id == id);

            HomeIndexVm indexvm = new HomeIndexVm
            {
                Beers = flavor.BeersWithFlavor.Select(fl => fl.Beer),
                Title = $"Beer with \"{flavor.Name}\" flavor"
            };
            return View("Index", indexvm);
        }

       /* [Route("ByBrewery/{id}")]*/
        public async Task<IActionResult> FindByBrewery(long? id)
        {
            Brouwerij brouwer = new Brouwerij();
            
            if (id != null)
            {
                brouwer = context.Brouwerijen.Find(id);
            }

            if (brouwer != null && id != null)
            {
                var bierenVanBrouwer = await context.Beers.Where(bier => bier.Brouwerij.Id == id)
                    .Include(smaak => smaak.Flavors)
                    .ThenInclude(a => a.Flavor)
                    .ToListAsync();
                var viewM = new HomeIndexVm {Beers = bierenVanBrouwer, Title = $"Bieren van brouwer {brouwer.Name}"};
                return View("Index", viewM);
            }
            else
            {
                var vm = new HomeIndexVm {Beers = null};
                return View("Index", vm);
            }
        }
    }
}
