using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationRestaurant.Models
{

    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailId { get; set; }


        [Required]
        public int Quantity { get; set; }


        #region Navigation Properties to Order Model

        [Required]
        public int OrderNumber { get; set; }


        [ForeignKey(nameof(OrderDetail.OrderNumber))]
        public Order Order { get; set; }


        //[Required]
        //public int CustomerId { get; set; }


        //[ForeignKey(nameof(OrderDetail.CustomerId))]
        //public Customer Customer { get; set; }

        #endregion


        #region Navigation Properties to MenuItem Model 

        [Required]
        public int MenuItemId { get; set; }


        [ForeignKey(nameof(OrderDetail.MenuItemId))]
        public MenuItem MenuItem { get; set; }

        #endregion


    }
}
