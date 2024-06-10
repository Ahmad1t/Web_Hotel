using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories._Generics
{
    public class GenericRepository<T> : IGenericRepo<T> where T : class
    {
        public readonly DbSet<T> _dbSet;
        public readonly HotelContext _umsContext;

        public GenericRepository(HotelContext umsContext)
        {
            _umsContext = umsContext;
            _dbSet = _umsContext.Set<T>();
        }

        public T Add(T entity)
        {
            
            try
            {
                _dbSet.Add(entity);
                _umsContext.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }

        #region Get
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        #endregion

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Update(T entity)
        {
            _dbSet.Update(entity);
            try
            {
                _umsContext.SaveChanges();
            }
            catch
            {

            }
            return entity;
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            try
            {
                _umsContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                return Delete(entity);
            }
            else
            {
                return false;
            }
        }

    }
}
