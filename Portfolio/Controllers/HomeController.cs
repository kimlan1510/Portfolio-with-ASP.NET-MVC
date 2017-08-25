using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult GetRepos()
        {
            var Repos = Repo.GetRepos();
            return View(Repos);
        }
        public IActionResult Journey()
        {
            return View();
        }
    }
}
