using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EE.Beers.Data;
using EE.Beers.Entities;
using EE.Beers.ViewModels;

namespace EE.Beers.Controllers
{
    public class BeersController : Controller
    {
        private readonly BeersContext _context;

        public BeersController(BeersContext context)
        {
            _context = context;
        }
        
        // GET: Beers/Create
        public IActionResult Create()
        {
            var createVm = new BeersCreateVm();
            createVm.BeschikbareBrowuers = _context.Brouwerijen.ToList();
            return View(createVm);
        }

        // POST: Beers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BeersCreateVm createVm)
        {
            if (ModelState.IsValid)
            {
                Brouwerij brouwerij = _context.Brouwerijen.Single(a => a.Id == createVm.BrouwerID);


                if (createVm.BrouwerID != null)
                {

                    if (brouwerij != null)
                    {
                        Beer gemaaktArtikel = new Beer
                        {
                            AlcoholByVolume = createVm.AlcoholByVolume,
                            BitteringIndex = createVm.BitteringIndex,
                            Name = createVm.Name,
                            IsActivelyBrewed = createVm.ActiveBrewed,
                            Brouwerij = brouwerij
                        };
                        _context.Add(gemaaktArtikel);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Create");
                    }
                    else
                    {
                        ModelState.AddModelError(nameof(createVm.BrouwerID), "Deze Brouwer bestaat niet of is verwijderd");
                    }
                }
            }
            createVm.BeschikbareBrowuers = _context.Brouwerijen.Where(a => a.Id != 0);
            return View(createVm);
        }
    }
}
