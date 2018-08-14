using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EE.Beers.Data;
using EE.Beers.ViewModels.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EE.Beers.Components
{
    [ViewComponent(Name = "BrouwersLijst")]
    public class BrouwerComponent : ViewComponent
    {
        private BeersContext _context;

        public BrouwerComponent(BeersContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AlleBrouwers = await _context.Brouwerijen.OrderBy(b => b.Name).ToListAsync();
            BrouwersComponentVm vm = new BrouwersComponentVm {AlleBrouwerijen = AlleBrouwers.OrderBy(d => d.Name) };
            return View(vm);
        }
    }
}
