using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyMVC.Models;

namespace MyMVC.ViewModels
{
    public class RandomMovieViewModels
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}