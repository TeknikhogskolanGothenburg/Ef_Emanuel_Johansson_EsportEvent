using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Data
{
    public abstract class GenericRepo<T,C> : 
        IGenericEsportRepo<T> where T : class where C : DbContext, new()
    {
        private C _context = new C();
        public C Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public void AddRangeAsync(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public void DeleteRangeAsync(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> FindByAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }

        public void UpdateRangeAsync(ICollection<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
