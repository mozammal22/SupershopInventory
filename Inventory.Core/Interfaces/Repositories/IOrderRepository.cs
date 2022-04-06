using Inventory.Core.Entity;
using Inventory.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Interfaces.Repositories
{
    public interface IOrderRepository:IBaseRepository<Order>
    {
    }
}
