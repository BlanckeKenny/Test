using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EE.Beers.Entities;

namespace EE.Beers.ViewModels.Components
{
    public class BrouwersComponentVm
    {
        public IEnumerable<Brouwerij> AlleBrouwerijen { get; set; }
    }
}
