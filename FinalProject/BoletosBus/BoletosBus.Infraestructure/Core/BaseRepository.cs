using BoletosBus.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace BoletosBus.Infraestructure.Core
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private DbSet<TEntity> _entities;

        protected BaseRepository(DbContext Context)
        {
            this._context = Context;
            this._entities = this._context.Set<TEntity>();
                
        }


        public async Task<List<TEntity>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<List<TEntity>> Exist(Expression<Func<TEntity, bool>> filter)
        {
           return await this._entities.Where(filter).ToListAsync();
        }

        public async Task<TEntity> GetById(int Id)
        {
            return await this._entities.FindAsync(Id);
        }

        public async Task Save(TEntity entity)
        {
            this._entities.Add(entity);
            await this._context.SaveChangesAsync();
        }

        public async Task Save(List<TEntity> entities)
        {
            this._entities.AddRange(entities);
            await this._context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            this._entities.Update(entity);
            await this._context.SaveChangesAsync();
        }

        public async Task Update(List<TEntity> entities)
        {
            this._entities.UpdateRange(entities);
            await this._context.SaveChangesAsync();
        }

        public async Task<TEntity> Delete(int Id)
        {
            TEntity entity = await _entities.FindAsync(Id);

            if (entity != null) 
            { 
                this._entities.Remove(entity);
                await this._context.SaveChangesAsync();
            
            }

            return entity;

        }

        
    }
}
