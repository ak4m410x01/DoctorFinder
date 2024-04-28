#region Using Directive Namespaces

using System.Linq.Expressions;

#endregion


namespace DoctorFinder.Application.Contracts.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        #region Get Objects List

        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> GetAllByAsync(Func<T, bool> predicate);
        Task<IQueryable<TResult>> GetAllByAsync<TResult>(Func<T, bool> predicate, Func<T, TResult> selector);

        #endregion


        #region Get Object

        Task<T?> GetByIdAsync(object id);
        Task<T?> GetByAsync(Expression<Func<T, bool>> predicate);

        #endregion


        #region Add

        Task AddAsync(T entity);

        #endregion

        #region Update

        Task UpdateAsync(T entity);

        #endregion

        #region Remove

        Task RemoveAsync(T entity);

        #endregion
    }
}
