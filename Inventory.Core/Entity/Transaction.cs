using Inventory.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Entity
{
    public class Transaction:BaseModel

    {
        public int UserID { get; set; }
        public int OrderID { get; set; }
        public string Date { get; set; }
        public int TotalAmount { get; set; }


    }
}
