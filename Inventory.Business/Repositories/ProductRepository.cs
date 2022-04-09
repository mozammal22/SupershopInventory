using Inventory.Business.Repositories.Base;
using Inventory.Core.Interfaces.Repositories;
using Inventory.Data.InventoryContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Repositories
{
    public class ProductRepository : BaseRepository<Inventory.Core.Entity.Product>, IProductRepository
    {
        private readonly InventoryDbContext context;

        public ProductRepository(InventoryDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
