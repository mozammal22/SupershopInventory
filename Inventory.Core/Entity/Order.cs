using Inventory.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Entity
{
    public class Order :BaseModel
    {
        public List<Product> Products { get; set; }
        public Customer Cashier { get; set; }
        //public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
