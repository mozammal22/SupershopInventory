using Inventory.Core.Entity.Base;
using Inventory.Core.Interfaces.Repositories.Base;
using Inventory.Data.InventoryContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Business.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly InventoryDbContext context;

        public BaseRepository(InventoryDbContext _context)
        {
            context = _context;
        }
        public void Add(T entity)
        {
            entity.CreatedTime = DateTime.Now;
            context.Set<T>().Add(entity);
        }

        public void AddRange(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void DeleteRange(List<T> entites)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            return GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            entity.ModifiedTime = DateTime.Now;
            context.Set<T>().Update(entity);
        }

        public void UpdateRange(List<T> entites)
        {
            throw new NotImplementedException();
        }
    }
}
