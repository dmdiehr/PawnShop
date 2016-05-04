using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ItemId { set; get; }
        public string Name { set; get; }
        public int RetailPrice { set; get; }
        public int WholesaleCost { set; get; }
        public int Inventory { set; get; }
         
        public Item(string name, int retailPrice, int wholesaleCost, int inventory, int id = 0 )
        {
            ItemId = id;
            Name = name;
            RetailPrice = retailPrice;
            WholesaleCost = wholesaleCost;
            Inventory = inventory;
        }

        public Item() { }
    }
}
