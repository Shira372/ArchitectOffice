using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class ArchitectService: IArchitectService
    {
        //IEnumerable<T> GetAll();
        //T? GetById(int id);
        //T Add(T entity);
        //T Update(T entity);
        //void Delete(T entity);
        private readonly IArchitectRepository _architectRepository;
        public ArchitectService(IArchitectRepository architectRepository)
        {
            _architectRepository = architectRepository;
        }
        public List<Architect> GetAll()
        {
            return _architectRepository.GetAll();
        }

        public Architect GetItem(int id)
        {
           return _architectRepository.GetById(id);
        }

        public void Post(Architect architect)
        {
             _architectRepository.Post(architect);
        }

        public int PutByArchitect(int id, Architect architect)
        {
            return _architectRepository.PutByArchitect(id,architect);
        }

        public int PutByStatus(int id, int status)
        {
           return _architectRepository.PutByStatus(id, status);
        }
    }
}
