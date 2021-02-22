using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        
        //constructor injection
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        //startup.cs configure default is homecontroller index action method 
        public IActionResult Index()
        {
            //instance of homeviewmodel the pies of the week
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
     
            return View(homeViewModel);
        }
    }
}
