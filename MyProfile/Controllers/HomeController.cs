using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProfile.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Protfolio> _portfolios = new List<Protfolio>
        {
            new Protfolio
            {
                Id = 1, Title = "KATANA", Image = "01.jpg", Description = "این اولین پروژه من بود!!!"
            },
            new Protfolio
            {
                Id = 2, Title = "پیام رسان", Image = "02.jpg", Description = "پیام رسان اختصاصی گروه برنامه نویسان"
            },
            new Protfolio
            {
                Id = 3, Title = "شبکه اجتماعی", Image = "03.jpg",
                Description = "شبکه اجتماعی ملی در راستای حمایت از تولید ملی"
            },
            new Protfolio
            {
                Id = 4, Title = "درخواست غذا", Image = "04.jpg",
                Description = "اپلیکیشن درخواست آنلاین غذای نیمه آماده و آماده طبخ"
            }
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "به سایت شخصی زینب رستمی  خوش آمدید";

            ViewBag.headingText =
                "این سایت به جهت معرفی من به مشتریان و کسانی که می خواهند از خدمات سایت بهره مند شوند طراحی و پیاده سازی شده است";
         
            return View(_portfolios);
            
           
        }
        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "hossein.abbasabadi@outlook.com",
                Mobile = "09128099518",
                Github = "github.com/atriya"
            };
            return View(contact);
        }
      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
