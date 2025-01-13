using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Services
{
    public interface IArchitectService
    {
        //?
        List<Architect> GetAll();
        //?
        Architect GetItem(int id);
        //?
        void Post(Architect architect);
        int PutByArchitect(int id, Architect architect);
        int PutByStatus(int id, int status);

    }
}
