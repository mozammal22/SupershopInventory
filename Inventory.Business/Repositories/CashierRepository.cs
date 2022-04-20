using Inventory.Business.Repositories.Base;
//using Inventory.Core.Entity;
using Inventory.Core.Interfaces.Repositories;
using Inventory.Data.InventoryContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Repositories
{
    public class CashierRepository : BaseRepository<Inventory.Core.Entity.Cashier>, ICashierRepository
    {
        private readonly InventoryDbContext context;

        public CashierRepository(InventoryDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
