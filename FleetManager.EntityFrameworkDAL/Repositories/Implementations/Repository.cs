#nullable enable 

using FleetManager.EntityFrameworkDAL.Models;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FleetManager.EntityFrameworkDAL.Context;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Repositories.Implementations;
public abstract class Repository<T> : IRepository<T> where T : Entity {
    protected readonly FleetManagerContext _context;

    public Repository(FleetManagerContext context) {
        _context = context;
    }

    public async Task<int> CreateAsync(T entity) {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity.ID;
    }

    public async Task DeleteAsync(int id) {
        await _context.Set<T>().Where(e => e.ID == id).ExecuteDeleteAsync();
    }

    public async Task<List<T>> GetAllAsync(int pageIndex, int pageLength) {
        return await _context.Set<T>()
            .Skip(pageIndex*pageLength)
            .Take(pageLength)
            .ToListAsync();
    }

    public virtual async Task<T?> GetByIDAsync(int id) {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task UpdateAsync(T entity) { 
        //Replace with ExecuteUpdate 
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task SaveChangesAsync() {
        await _context.SaveChangesAsync();
    }
}
