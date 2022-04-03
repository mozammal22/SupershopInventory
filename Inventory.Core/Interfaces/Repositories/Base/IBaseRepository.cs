using Inventory.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        IQueryable<T> GetAll();
        T Find(int id);

        void Add(T entity);

        void AddRange(List<T> entities);

        void Delete(T entity);


        void DeleteRange(List<T> entites);
        void Update(T entity);

        void UpdateRange(List<T> entites);


        void SaveChanges();
        Task SaveChangesAsync();
    }
}
