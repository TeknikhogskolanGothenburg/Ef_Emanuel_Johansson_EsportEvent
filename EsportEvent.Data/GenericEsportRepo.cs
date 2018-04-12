using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Data
{
    public abstract class GenericEsportRepo<T, C> where T : class where C : DbContext, new()
    {
        private C _context = new C();
        public C Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public virtual ICollection<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual async Task<ICollection<T>> GetAllAsync() 
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual ICollection<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }

        public virtual async Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual async void AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public virtual void AddRange(ICollection<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public virtual async void AddRangeAsync(ICollection<T> entities)
        {
          await  _context.Set<T>().AddRangeAsync(entities);        
        }


        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public virtual void DeleteRange(ICollection<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public virtual void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public virtual void UpdateRange(ICollection<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

        public virtual void SaveAsync()
        {
            _context.SaveChangesAsync();
        }

    }
}
