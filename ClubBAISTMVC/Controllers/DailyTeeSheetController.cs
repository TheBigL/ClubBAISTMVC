using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClubBAISTMVC.Controllers
{
    public class DailyTeeSheetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}