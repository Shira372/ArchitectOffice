using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface IArchitectRepository
    {
        List<Architect> GetAll();
        Architect GetById(int id);
        void Post(Architect architect);
        public int PutByArchitect(int id, Architect architect);
        public int PutByStatus(int id, int status);
    }
}
