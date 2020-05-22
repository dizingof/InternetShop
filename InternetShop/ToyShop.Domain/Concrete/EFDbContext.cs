using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.Domain.Entities;

namespace ToyShop.Domain.Concrete
{
    class EFDbContext:DbContext
    {
        public DbSet<Toy> Toys { get; set; }
    }
}
