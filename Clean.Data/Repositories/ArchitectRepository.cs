using Clean.Core.Models;
using Clean.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clean.Data.Repositories
{
    public class ArchitectRepository:Repository<Architect>, IArchitectRepository
    {
        protected readonly DataContext _context;
        public ArchitectRepository(DataContext context) : base(context)
        {
        }
        public IEnumerable<Architect> GetList()
        {
            return _context.Architects.Include(u => u.Plan);
        }

        public void Post(Architect architect)
        {
            throw new NotImplementedException();
        }

        public int PutByArchitect(int id, Architect architect)
        {
            for (int i = 0; i < _context.Architects.ToList().Count; i++)
            {
                if (_context.Architects.ToList()[i].Id == id)
                {
                    _context.Architects.ToList().RemoveAt(i);
                    _context.Architects.ToList().Insert(i, architect);
                    //_context.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }
        public int PutByStatus(int id, int status)
        {
            for (int i = 0; i < _context.Architects.ToList().Count; i++)
            {
                if (_context.Architects.ToList()[i].Id == id)
                {
                    _context.Architects.ToList()[i].Status = status;
                    //_context.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        List<Architect> IArchitectRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

    