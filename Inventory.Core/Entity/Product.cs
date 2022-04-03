using Inventory.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Entity
{
    public class Product : BaseModel
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; } 
    }
}
