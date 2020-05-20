using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShop.Domain.Entities;

namespace ToyShop.Domain.Abstract
{
    public interface IToyRepository
    {
        IEnumerable<Toy> Toys { get; }
    }
}
