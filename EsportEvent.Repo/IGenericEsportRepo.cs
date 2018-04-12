using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EsportEvent.Data
{
    interface IGenericEsportRepo <T> where T : class
    {
        ICollection<T> GetAll();
        Task<ICollection<T>> GetAllAsync();

        ICollection<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddAsync(T entity);
        void AddRange(ICollection<T> entities);
        void AddRangeAsync(ICollection<T> entities);


        void Delete(T entity);
        void DeleteAsync(T entity);
        void DeleteRange(ICollection<T> entities);
        void DeleteRangeAsync(ICollection<T> entities);

        void Update(T entity);
        void UpdateAsync(T entity);
        void UpdateRange(ICollection<T> entities);
        void UpdateRangeAsync(ICollection<T> entities);

        void Save();
        void SaveAsync();

    }
}
