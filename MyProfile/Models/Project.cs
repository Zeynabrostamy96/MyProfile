using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class Project
    {
        public int id { get; set; }
        
        public string Name { get; set; }
        public  string Description { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }
        public Project(int Id,string name, string description, string client, string image)
        {
            id = Id;
            Name = name;
            Description = description;
            Client = client;
            Image = image;
              

        }
    }
}
