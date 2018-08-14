using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EE.Beers.Data;
using EE.Beers.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EE.Beers.Controllers
{

    public class SearchController : Controller
    {
        private BeersContext _context;

        public SearchController(BeersContext context)
        {
            this._context = context;
        }


        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Search(decimal minAlc, decimal maxAlc, string startWith, bool activeBrewed)
        {

            if (ModelState.IsValid)
            {
                var searchBeers = await _context.Beers.Where(b => b.AlcoholByVolume >= (double) minAlc
                                                                 && b.AlcoholByVolume <=  (double) maxAlc
                                                                 && b.Name.ToUpper().StartsWith (startWith)
                                                                 && b.IsActivelyBrewed == activeBrewed)
                    .Include(b => b.Flavors)
                    .ThenInclude(fl => fl.Flavor)
                    .ToListAsync();

                SearchIndexVm vm = new SearchIndexVm{Bieren = searchBeers};

                if (searchBeers.Count == 0)
                {
                    return View("Search", vm);
                }
                else
                    return View("SearchResults", vm);


            }


            return View();
        }
    }
}