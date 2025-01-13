using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public interface IRepositoryManager
    {
        IArchitectRepository ArchitectRepository { get; }
        void Save();
    }
}
