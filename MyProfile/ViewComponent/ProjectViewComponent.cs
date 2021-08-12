using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Data;
using MyProfile.Models;

namespace MyProfile.ViewComponentt
{
    public class ProjectViewComponent:ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            var project = ProjectStor.GetProject();

            return View("_Project",project);
        }
    }
}
