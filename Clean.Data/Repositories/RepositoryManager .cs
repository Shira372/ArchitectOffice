using Clean.Core.Models;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<Architect> Architects { get; }

        public IArchitectRepository ArchitectRepository => throw new NotImplementedException();

        public RepositoryManager(DataContext context, IRepository<Architect> architectRepository)
        {
            _context = context;
            Architects = architectRepository;
        }

        public async void SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}


