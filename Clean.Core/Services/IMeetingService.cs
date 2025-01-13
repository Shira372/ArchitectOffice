using ArchitectsOffice.Entities;
using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Services
{
    public interface IMeetingService
    {
        List<Meeting> GetAll();
        Meeting Get(int id);
        Meeting GetByStart(DateTime start);
        void Post(Meeting metting);
        int Put(int id, Meeting metting);
        int Delete(int id);
    }
}
