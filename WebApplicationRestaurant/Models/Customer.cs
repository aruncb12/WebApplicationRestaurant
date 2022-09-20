using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplicationRestaurant.Models
{
    [Table(name: "Customers")]
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }




    }
}
