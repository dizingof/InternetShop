using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.Domain.Abstract;
using ToyShop.Domain.Entities;

namespace ToyShop.Domain.Concrete
{
    public class EFToyRepository : IToyRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Toy> Toys
        {
            get { return context.Toys; }
        }
    }
}
