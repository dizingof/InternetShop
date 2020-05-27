using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyShop.Domain.Abstract;
using ToyShop.Domain.Entities;
using ToyShop.WebUI.Models;
using ToyShop.Domain.Concrete;

namespace ToyShop.WebUI.Controllers
{
    public class ToyController : Controller
    {
        private IToyRepository toyRepository;
        public int pageSize = 2;
        public ToyController(IToyRepository Repository)
        {
            toyRepository = Repository;
        }
        public ViewResult List(string category, int page = 1)
        {
          ToysListViewModel model = new ToysListViewModel
          {
                Toys = toyRepository.Toys
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(toy => toy.ToyId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ?
                    toyRepository.Toys.Count() :
                    toyRepository.Toys.Where(toy => toy.Category == category).Count()
                },
              CurrentCategory = category

          };

            return View(model);
        }
    }
}