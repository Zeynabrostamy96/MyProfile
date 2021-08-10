using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است ")]
        [StringLength(120,MinimumLength =5,ErrorMessage = "لطفا از5 کاراکتر کمتروارد نکنید ")]
        public string Name { get; set; }
        [Required(ErrorMessage ="این فیلد اجباری است  ")]
        [MaxLength(500)]
        [EmailAddress]
        public string Email { get; set; }
        public int service { get; set; }
        public string message { get; set; }
        public SelectList services { get; set; }

    }
}
