#region Using Directive Namespaces

using DoctorFinder.Application.Contracts.Interfaces.Repositories.Base;
using DoctorFinder.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

#endregion

namespace DoctorFinder.Persistence.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        #region Constructors

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion


        #region Properties

        protected ApplicationDbContext _context;

        #endregion


        #region Get Objects List

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.FromResult(_context.Set<T>().AsNoTracking());
        }
        public async Task<IQueryable<T>> GetAllByAsync(Func<T, bool> predicate)
        {
            return await Task.FromResult(_context.Set<T>().AsNoTracking().Where(predicate).AsQueryable());
        }
        public async Task<IQueryable<TResult>> GetAllByAsync<TResult>(Func<T, bool> predicate, Func<T, TResult> selector)
        {
            return await Task.FromResult(_context.Set<T>().AsNoTracking().Where(predicate).Select(selector).AsQueryable());
        }

        #endregion


        #region Get Object

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T?> GetByAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
        }

        #endregion


        #region Add

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        #endregion

        #region Update

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);

            await _context.SaveChangesAsync();
        }

        #endregion

        #region Remove

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);

            await _context.SaveChangesAsync();
        }

        #endregion
    }
}
