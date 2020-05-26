using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyShop.Domain.Abstract;

namespace ToyShop.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IToyRepository repository;

        public NavController(IToyRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu()
        {
            IEnumerable<string> categories = repository.Toys
                .Select(toy => toy.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}