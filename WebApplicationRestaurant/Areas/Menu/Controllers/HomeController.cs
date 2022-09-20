using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using WebApplicationRestaurant.Models;

namespace WebApplicationRestaurant.Areas.Menu.Controllers
{
    public class ShowMenuViewModel
    {

        [Required(ErrorMessage = "{0} cannot be empty")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }


        public ICollection<MenuItem> MenuItems { get; set; }

        public int? Quantity { get; set; }

    }
}
