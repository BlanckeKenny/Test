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
        
    }
}
