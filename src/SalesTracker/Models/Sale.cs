using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Sales")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        public virtual ICollection<Item> ItemList { get; set; }

        [ForeignKey("ApplicationUser")]
        public string SalesPersonId { get; set; }

        public int TotalPrice
        {
            get
            {
                int returnValue=0;
                foreach(Item item in ItemList)
                {
                    returnValue += item.RetailPrice;
                }

                return returnValue;
            }
        }


        public Sale()
        {
            ItemList = new HashSet<Item>();
        }
    }

}
