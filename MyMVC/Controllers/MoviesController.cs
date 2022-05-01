using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVC.Models;
using MyMVC.ViewModels;

namespace MyMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Ramdom
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The 100",Id=1 };
            var customer = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };
            var viewModel = new RandomMovieViewModels()
            {
                Movie = movie,
                Customer = customer
            };
            return View(viewModel);
        }
        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format($"pageIndex={pageIndex},sortBy={sortBy}"));
        //}
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}