using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GuniApp.Web.Models

{
    public class MyIdentityRole
        : IdentityRole<Guid>
    {
        [Display(Name = "Description")]
        [StringLength(100,ErrorMessage ="{0} cannot have more than {1} characters.")]
        public string Decription { get; set; }
    }
}
