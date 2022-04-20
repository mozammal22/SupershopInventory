using Inventory.Business.Repositories.Base;
using Inventory.Core.Entity;
using Inventory.Core.Interfaces.Repositories;
using Inventory.Data.InventoryContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        private readonly InventoryDbContext context;

        public CustomerRepository(InventoryDbContext _context) : base(_context)
        {
            context = _context;
        }

        public void GenerateDiscountByCustomer(int cutomerId)
        {
            throw new NotImplementedException();
        }
    }
}
