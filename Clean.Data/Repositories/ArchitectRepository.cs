using Clean.Core.Models;
using Clean.Data.Repositories;
using Clean.Data;
using Microsoft.EntityFrameworkCore;


public class ArchitectRepository : Repository<Architect>, IArchitectRepository
{
    protected readonly DataContext _context;

    public ArchitectRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Architect>> GetAllAsync()
    {
        return await _context.Architects.Include(u => u.Plan).ToListAsync();  // שינוי לאסינכרוני
    }

    public async Task<Architect> GetItemAsync(int id)
    {
        return await _context.Architects.Include(u => u.Plan).FirstOrDefaultAsync(a => a.Id == id);  // חיפוש אסינכרוני
    }

    public async Task<int> PutByArchitectAsync(int id, Architect architect)
    {
        var existingArchitect = await _context.Architects.FindAsync(id);
        if (existingArchitect == null)
        {
            return 0;
        }

        _context.Entry(existingArchitect).CurrentValues.SetValues(architect);
        //await _context.SaveChangesAsync();
        return 1;
    }

    public async Task<int> PutByStatusAsync(int id, int status)
    {
        var architect = await _context.Architects.FindAsync(id);
        if (architect == null)
        {
            return 0;
        }

        architect.Status = status;
       // await _context.SaveChangesAsync();
        return 1;
    }

    public async Task PostAsync(Architect architect)
    {
        await _context.Architects.AddAsync(architect);  // הוספה אסינכרונית
        //await _context.SaveChangesAsync();
    }

    public Task<int> PutByArchitectAsync(Architect architect)
    {
        throw new NotImplementedException();
    }
}
