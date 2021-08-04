using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;

namespace MyProfile.ViewComponentt
{
    public class ProjectViewComponent:ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {

            var projects = new List<Project>
        {
         new Project(1,"تاکسی","درخواست انلاین تاکسی برای سفرهای درون شهری ","snap","project-1.jpg"),
         new Project(2,"زودفو","درخواست انلاین غذا برای سراسرکشور","zoodfood","project-2.jpg"),
         new Project(3,"مدارس","سیستم مدیریت یکپارچه","parvin","project-3.jpg"),
         new Project(4,"فضا پیما","سیستم مدیریت ناسا","nasa","project-4.jpg"),
        };
            return View("_Project",projects);
        }
    }
}
