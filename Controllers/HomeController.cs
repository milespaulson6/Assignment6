using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models.ViewModels;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {//this is the readonly logger
        private readonly ILogger<HomeController> _logger;
        private ILetriniaRepository _repository;

        public int PageSize = 5;
        //this passes into the homecontroller the logger and the repository
        public HomeController(ILogger<HomeController> logger, ILetriniaRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int page = 1)
        {//this makes sure all requirements are satsfied, if not the page will give error messages for the incorrect inputs
            if (ModelState.IsValid)
            {
                return View(new BookListViewModel
                {
                    Products = _repository.Products
                    .OrderBy(p => p.BookID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),

                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        BooksPerPage = PageSize,
                        TotalNumBooks = _repository.Products.Count()
                    }
            });
                    
                   
                    
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
