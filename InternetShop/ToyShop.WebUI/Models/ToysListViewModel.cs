using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToyShop.Domain.Entities;

namespace ToyShop.WebUI.Models
{
    public class ToysListViewModel
    {
        public IEnumerable<Toy> Toys { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}