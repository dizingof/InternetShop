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
        // GET: Toy
        public ToyController(IToyRepository Repository)
        {
            toyRepository = Repository;
        }
        public ViewResult List()
        {
            return View(toyRepository.Toys);
        }
    }
}