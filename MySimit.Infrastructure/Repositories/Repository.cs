using Microsoft.EntityFrameworkCore;
using MySimit.Admin.Application.Interface;

namespace MySimit.Infrastructure.Interface;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task <T?> GetById(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<List<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
    }

    public int Delete(int id)
    {
        var entity = _dbSet.Find(id);
        if (entity == null)
        {
            return -1;
        }
        _dbSet.Remove(entity);
        return 1;
    }
}