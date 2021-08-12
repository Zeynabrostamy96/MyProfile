using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProfile.Models;

namespace MyProfile.Data
{
    public class ProjectStor
    {
        public static  List<project> GetProject()
        {
            return new List<project>
            {
       
            new project(1,"تاکسی","درخواست انلاین تاکسی برای سفرهای درون شهری ","snap","project-1.jpg"),
            new project(2,"زودفو","درخواست انلاین غذا برای سراسرکشور","zoodfood","project-2.jpg"),
            new project(3,"مدارس","سیستم مدیریت یکپارچه","parvin","project-3.jpg"),
            new project(4,"فضا پیما","سیستم مدیریت ناسا","nasa","project-4.jpg"),
            };
        }
        public static  project showproject(int id)
        {
            return GetProject().FirstOrDefault(c=>c.id==id);
        }
    
    }
}
