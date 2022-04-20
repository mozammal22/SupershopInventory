using Inventory.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Entity
{
    public class Transaction : BaseModel

    {
        public Order Order { get; set; }
        public int TotalAmount { get; set; }
        public string ChallanNo { get; set; }

        public Cashier User { get; set; }
    }
}
