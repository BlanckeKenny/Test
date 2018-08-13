using EE.Beers.Entities;
using System.Collections.Generic;

namespace EE.Beers.ViewModels
{
    public class HomeIndexVm
    {
        public string Title { get; set; }

        public IEnumerable<Beer> Beers { get; set; }
    }
}
