using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyShop.Domain.Abstract;
using ToyShop.Domain.Entities;

namespace ToyShop.WebUI.Controllers
{
    public class ToyController : Controller
    {
        private IToyRepository toyRepository;
        public int pageSize = 3;
        public ToyController(IToyRepository Repository)
        {
            toyRepository = Repository;
        }
        public ViewResult List(int page = 1)
        {
            return View(toyRepository.Toys
                        .OrderBy(toy => toy.ToyId)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize));
        }
    }
}