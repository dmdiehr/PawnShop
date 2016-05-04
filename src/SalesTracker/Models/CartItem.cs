using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SalesTracker.Models
{
    [Table("CartItems")]
    public class CartItems
    {
        [Key]
        public int CartItemId { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }

    }
}
