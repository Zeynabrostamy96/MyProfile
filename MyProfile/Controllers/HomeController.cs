using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProfile.Models;
using System.Collections.Generic;
using System.Diagnostics;
namespace MyProfile.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی زینب رستمی  خوش آمدید";

            ViewBag.headingText =
                "این سایت به جهت معرفی من به مشتریان و کسانی که می خواهند از خدمات سایت بهره مند شوند طراحی و پیاده سازی شده است";
         
            return View();
            
           
        }
        public IActionResult Contact()
        {
           //''''
            return View();
        }
      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
