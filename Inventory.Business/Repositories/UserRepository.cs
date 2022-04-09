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
    public class UserRepository : BaseRepository<Inventory.Core.Entity.User>, IUserRepository
    {
        private readonly InventoryDbContext context;

        public UserRepository(InventoryDbContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
