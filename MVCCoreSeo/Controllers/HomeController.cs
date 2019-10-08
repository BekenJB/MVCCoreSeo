using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetSeo.CoreMvc;
using Microsoft.AspNetCore.Mvc;
using MVCCoreSeo.Models;

namespace MVCCoreSeo.Controllers
{
    public class HomeController : SeoController
    {
        public IActionResult Index()
        {
            this.Seo.PageTitle = "This is a quick demo on how to add meta tags to asp.net core";
            this.Seo.MetaDescription = "What Are Meta Tags? Meta tags helps you with seo. sample test.";
            this.Seo.MetaKeywords = "Seo, Meta tags, Search Engines";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
